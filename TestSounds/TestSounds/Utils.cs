using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSounds
{
    // Class to hold static helper data
    class Utils
    {
        private static Dictionary<char, char> _conversionTable;
        public static Dictionary<char, char> ConversionTable
        {
            get 
            {
                if(_conversionTable == null)
                    InitializeConversionTable();
                return _conversionTable;
            }
        }
        
        private static void InitializeConversionTable()
        {
            _conversionTable = new Dictionary<char, char>();
            Dictionary<char, char> conversionTable2 = new Dictionary<char, char>();
            _conversionTable.Add('a', '\u0250');
            _conversionTable.Add('b', 'q');
            _conversionTable.Add('c', '\u0254'); 
            _conversionTable.Add('d', 'p');
            _conversionTable.Add('e', '\u01DD');
            _conversionTable.Add('f', '\u025F'); 
            _conversionTable.Add('g', '\u0183');
            _conversionTable.Add('h', '\u0265');
            _conversionTable.Add('i', '\u0131'); 
            _conversionTable.Add('j', '\u027E');
            _conversionTable.Add('k', '\u029E');
            _conversionTable.Add('m', '\u026F');
            _conversionTable.Add('n', 'u');
            _conversionTable.Add('r', '\u0279');
            _conversionTable.Add('t', '\u0287');
            _conversionTable.Add('v', '\u028C');
            _conversionTable.Add('w', '\u028D');
            _conversionTable.Add('y', '\u028E');
            _conversionTable.Add('.', '\u02D9');
            _conversionTable.Add('[', ']');
            _conversionTable.Add('(', ')');
            _conversionTable.Add('{', '}');
            _conversionTable.Add('?', '\u00BF');
            _conversionTable.Add('!', '\u00A1');
            _conversionTable.Add('\'', ',');
            _conversionTable.Add('<', '>');
            _conversionTable.Add('_', '\u203E');
            _conversionTable.Add(';', '\u061B');
            _conversionTable.Add('\u203F', '\u2040');
            _conversionTable.Add('\u2045', '\u2046');
            _conversionTable.Add('\u2234', '\u2235');
            _conversionTable.Add('\r', '\n');
            _conversionTable.Add('A', '\u2200');
            _conversionTable.Add('C', '\u0186');
            _conversionTable.Add('E', '\u018E');
            _conversionTable.Add('F', '\u2132');
            _conversionTable.Add('G', '\u05E4');
            _conversionTable.Add('J', '\u017F');
            _conversionTable.Add('K', '\u22CA');
            _conversionTable.Add('L', '\u02E5');
            _conversionTable.Add('M', 'W');
            _conversionTable.Add('P', '\u0500');
            _conversionTable.Add('T', '\u2534');
            _conversionTable.Add('U', '\u2229');
            _conversionTable.Add('V', '\u039B');
            _conversionTable.Add('Y', '\u2144');
            
            //for reverse mappings 
            foreach (KeyValuePair<char, char> item in _conversionTable)
            {
                conversionTable2.Add(item.Value, item.Key);
            }
            // Add the reverse mappings to the main table.
            foreach (KeyValuePair<char, char> item in conversionTable2)
            {
                _conversionTable.Add(item.Key, item.Value);
            }
        }       
        
    }
}
