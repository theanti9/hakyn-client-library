using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

using libhakyn.Command;

namespace libhakyn.Connection
{
    public class GameConnection
    {
        private const int BUFF_SIZE = 1024;
        private string host;
        private int port;
        private string token;
        private TcpClient client;
        private static Thread writeRunnerThread;
        private static Thread readRunnerThread;
        private List<byte> outputQueue;
        private static ManualResetEvent writerReset;

        public GameConnection(string host, int port, string token)
        {
            this.host = host;
            this.port = port;
            this.token = token;
            this.outputQueue = new List<byte>();
            writerReset = new ManualResetEvent(false);
        }

        public void Write(byte[] bytes)
        {
            this.outputQueue.AddRange(bytes);
            writerReset.Set();
        }

        public void Start()
        {
            client = new TcpClient();
            try
            {
                Command.CommandProcessor.setup();
                client.Connect(host, port);
                if (client.Connected)
                {
                    // TODO write login packet to network here
                    writeRunnerThread = new Thread(new ThreadStart(handleOutgoing));
                    writeRunnerThread.Start();
                    readRunnerThread = new Thread(new ThreadStart(handleIncoming));
                    readRunnerThread.Start();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace + e.Message);
            }
        }

        private void handleOutgoing()
        {
            while (client.Connected)
            {
                try
                {
                    int size = (this.outputQueue.Count - 1 > BUFF_SIZE) ? BUFF_SIZE : this.outputQueue.Count - 1;
                    if (size > 0)
                    {
                        client.GetStream().Write(this.outputQueue.GetRange(0, size).ToArray(), 0, size);
                        outputQueue.RemoveRange(0, size);
                    }
                    else
                    {
                        writerReset.WaitOne();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace + e.Message);
                }
            }
        }

        private void handleIncoming()
        {
            while (client.Connected)
            {
                try
                {
                    byte[] buffer = new byte[BUFF_SIZE];
                    int bytesRead = client.GetStream().Read(buffer, 0, BUFF_SIZE);
                    if (bytesRead > 0)
                    {
                        Command.CommandProcessor.Queue.AddRange(buffer);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace + e.Message);
                }
            }
        }
    }
}
