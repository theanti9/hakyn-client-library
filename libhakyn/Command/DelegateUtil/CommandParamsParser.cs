using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using libhakyn.Util;

namespace libhakyn.Command.DelegateUtil
{
    public static class CommandParamsParser
    {
        public static List<object> parseBytes(byte[] bytes, byte command)
        {
            List<object> Params = new List<object>();

            switch (command)
            {
                case 0x01:
                    if (bytes.Length != 32)
                    {
                        throw new ArgumentException("Invalid array length for given command: 0x01");
                    }

                    Params.Add(Encoding.ASCII.GetString(ArrayUtil.ByteSubArray(bytes, 0, 24))); // Character id
                    Params.Add(BitConverter.ToInt32(bytes, 24)); // X coordinate
                    Params.Add(BitConverter.ToInt32(bytes, 28)); // Y coordinate
                    break;
                case 0x02:
                    if (bytes.Length != 36)
                    {
                        throw new ArgumentException("Invalid array length for given command: 0x02");
                    }
                    Params.Add(Encoding.ASCII.GetString(ArrayUtil.ByteSubArray(bytes, 0, 24))); // Monster instance id
                    Params.Add(BitConverter.ToInt32(bytes, 24)); // Monster id
                    Params.Add(BitConverter.ToInt32(bytes, 28)); // X coordinate
                    Params.Add(BitConverter.ToInt32(bytes, 32)); // Y coordinate
                    break;
            }


            return Params;
        }
    }
}
