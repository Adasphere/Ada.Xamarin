using System;
using System.Linq;

namespace Ada.Xamarin.FileStorage.Abstractions
{
    public static class Extensions
    {
        /// <summary>
        /// Cleans from a byte array a byte order mark if it exists
        /// </summary>
        /// <param name="bytes">The original byte array</param>
        /// <returns>A byte array without a byte order mark if it exists</returns>
        public static byte[] CleanByteOrderMark(this byte[] bytes)
        {
            byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };

            // If the first 3 bytes are byte order marker, 
            // then this pulls them out of the array
            if (bytes.Take(3).SequenceEqual(bom))
            {
                return bytes.Skip(3).ToArray();
            }

            return bytes;
        }
    }
}
