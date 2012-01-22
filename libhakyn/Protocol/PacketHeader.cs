using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using libhakyn.Util;

namespace libhakyn.Protocol
{
    public class PacketHeader
    {
        public Byte Command;
        public int Length;

        public const string TAG = "HAK";

        public PacketHeader(byte[] bytes)
        {
            if (new String(Encoding.ASCII.GetChars(bytes, 0, 3)) != TAG)
            {
                throw new ArgumentException("Fixed header did not begin with correct tag");
            }
            this.Length = BitConverter.ToInt32(bytes, 4);
            this.Command = bytes[8];
        }

        public PacketHeader(int length, Byte command)
        {
            this.Length = length;
            this.Command = command;
        }

        public byte[] getBytes()
        {
            byte[] output = new byte[9];
            Array.Copy(TAG.ToCharArray(), output, 3L);
            Array.Copy(BitConverter.GetBytes(this.Length), 0, output, 3, 4);
            Array.Copy(new Byte[] {0x00, this.Command}, 0, output, 7, 2);
            return output;
        }

    }
}
