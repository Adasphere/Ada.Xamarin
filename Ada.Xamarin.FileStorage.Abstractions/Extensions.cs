﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ada.Xamarin.FileStorage.Abstractions
{
    public static class Extensions
    {
        public static byte[] CleanByteOrderMark(this byte[] i_Bytes)
        {
            byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };

            if (i_Bytes.Take(3).SequenceEqual(bom))
            {
                return i_Bytes.Skip(3).ToArray();
            }

            return i_Bytes;
        }
    }
}
