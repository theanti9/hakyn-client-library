using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace libhakyn.Util
{
    public class ArrayUtil
    {
        // Found this on stack overflow
        // Get a subsection of an array
        public static byte[] ByteSubArray(byte[] data, int index, int length)
        {
            byte[] result = new byte[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static byte[] StringToBytes(string str)
        {
            return System.Text.ASCIIEncoding.ASCII.GetBytes(str);
        }

        public static byte[] ReverseBytes(byte[] data)
        {
            byte[] output = new byte[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                output[i] = data[data.Length - i - 1];
            }

            return output;
        }
    }
}
