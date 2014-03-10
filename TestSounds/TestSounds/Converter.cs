using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSounds
{
    // This class will include all the methods for String conversions.
    class Converter
    {
        public static String InvertString(String inputString)
        {
            int last = inputString.Length - 1;
            char[] chars = inputString.ToCharArray();
            for (var i = last; i >= 0; --i)
            {
                char c = inputString[i];
                chars[last - i] = Utils.ConversionTable.ContainsKey(c) ? Utils.ConversionTable[c] : c;
            }

            String outputString = new String(chars);
            return outputString;
        }
    }
}
