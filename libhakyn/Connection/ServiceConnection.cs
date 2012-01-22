using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


using libhakyn.Util;

namespace libhakyn.Connection
{
    public class ServiceConnection
    {
        private const int BUFF_SIZE = 1024;
        private byte[] buffer = new byte[BUFF_SIZE];

        private string host;
        private int port;
        private string charid;
        private TcpClient client;
        private NetworkStream networkStream;
        private static Thread runnerThread;


        public ServiceConnection(string host, int port, string charid)
        {
            this.host = host;
            this.port = port;
            this.charid = charid;
        }

        public void Start()
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, port);
                networkStream = client.GetStream();
                networkStream.Write(ArrayUtil.StringToBytes(this.charid), 0, this.charid.Length);
                runnerThread = new Thread(new ThreadStart(handle));
                runnerThread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void handle()
        {
            while (client.Connected)
            {
                StateObject state = new StateObject();
                state.networkStream = networkStream;
                networkStream.BeginRead(state.buffer, 0, BUFF_SIZE, new AsyncCallback(readCallback), state);
            }
        }

        private static void readCallback(IAsyncResult iar)
        {
            try
            {
                StateObject state = (StateObject)iar.AsyncState;
                int bytesRead = state.networkStream.EndRead(iar);
                if (bytesRead > 0)
                {
                    Command.CommandProcessor.Queue.AddRange(state.buffer);
                    state.networkStream.BeginRead(state.buffer, 0, BUFF_SIZE, new AsyncCallback(readCallback), state);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
