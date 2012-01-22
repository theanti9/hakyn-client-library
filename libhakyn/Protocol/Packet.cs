using System;
using System.Collections.Generic;
using System.Text;

using libhakyn.Util;

namespace libhakyn.Protocol
{
    public class Packet
    {
        public PacketHeader Header;
        public byte[] Body;

        public Packet(byte[] bytes)
        {
            this.Header = new PacketHeader(ArrayUtil.ByteSubArray(bytes, 0, 9));
            this.Body = ArrayUtil.ByteSubArray(bytes, 9, bytes.Length - 10);
        }

        public Packet(PacketHeader header, byte[] body)
        {
            this.Header = header;
            this.Body = body;
        }

        public byte[] getBytes()
        {
            byte[] output = new byte[Header.Length + 9];
            Array.Copy(this.Header.getBytes(), output, 9);
            Array.Copy(this.Body, 0, output, 9, this.Header.Length);
            return output;
        }
    }
}
