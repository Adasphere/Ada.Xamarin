using System;
using System.Linq;

namespace Ada.Xamarin.FileStorage.Abstractions
{
    public static class Extensions
    {
        public static byte[] CleanByteOrderMark(this byte[] bytes)
        {
            byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };

            if (bytes.Take(3).SequenceEqual(bom))
            {
                return bytes.Skip(3).ToArray();
            }

            return bytes;
        }
    }
}
