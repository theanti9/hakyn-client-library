﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using libhakyn.Util;
using libhakyn.Protocol;
using libhakyn.Command.DelegateUtil;
namespace libhakyn.Command
{
    public class CommandProcessor
    {
        public static List<byte> Queue = new List<byte>();
        public static bool processing = false;
        public static Thread runnerThread;
        public static ManualResetEvent runnerReset;

        public static void setup()
        {
            runnerReset = new ManualResetEvent(false);
            runnerThread = new Thread(new ThreadStart(process));
            runnerThread.Start();
        }


        public static void enqueue(byte[] bytes)
        {
            Queue.AddRange(bytes);
            runnerReset.Set();
        }

        private static void process()
        {
            

            // There needs to be at least a header to get
            while (Queue.Count > 9)
            {
                byte[] hak = Queue.GetRange(0, 3).ToArray();
                if (Encoding.ASCII.GetString(hak) == PacketHeader.TAG)
                {
                    PacketHeader ph = new PacketHeader(Queue.GetRange(0, 9).ToArray());
                    Packet pack = new Packet(ph, Queue.GetRange(9, ph.Length).ToArray());
                    // Remove the stuff we've gathered
                    Queue.RemoveRange(0, ph.Length + 9);

                    if (CommandDelegates.CommandInitialized(ph.Command))
                    {
                        switch (ph.Command) 
                        {
                            case 0x01:      // Update position
                                CommandDelegates.UpdatePositionDelegate upd = (CommandDelegates.UpdatePositionDelegate)CommandDelegates.getInitializedDelegate(ph.Command);
                                upd.Invoke(CommandParamsParser.parseBytes(pack.Body, ph.Command));
                                break;
                            case 0x02:      // Spawn Monster
                                CommandDelegates.SpawnMonsterDelegate smd = (CommandDelegates.SpawnMonsterDelegate)CommandDelegates.getInitializedDelegate(ph.Command);
                                smd.Invoke(CommandParamsParser.parseBytes(pack.Body, ph.Command));
                                break;
                        }
                    }
                    else
                    {
                        // This means we're not supposed to act uppon the command
                    }

                }
                else
                {
                    // for now, throw away the first byte and try to look for the tag again
                    Queue.RemoveAt(0);
                    continue;
                }
            }
            // Pause the thread. It will be resumed when data is enqueued.
            runnerReset.WaitOne();
        }

    }
}
