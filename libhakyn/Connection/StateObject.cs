using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace libhakyn.Connection
{
    class StateObject
    {
        public NetworkStream networkStream;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
    }
}
