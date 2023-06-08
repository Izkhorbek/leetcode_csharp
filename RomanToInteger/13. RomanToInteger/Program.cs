using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ret = RomanToInt("LVIII");
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> keyValues = new Dictionary<char, int>
            {
                {'I',  1},
                {'V',  5},
                {'X',  10},
                {'L',  50},
                {'C',  100},
                {'D',  500},
                {'M', 1000}
            };

            int nNumeral = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (keyValues[s[i]] < keyValues[s[i + 1]])
                {
                    nNumeral = nNumeral - keyValues[s[i]];
                }
                else
                {
                    nNumeral = nNumeral + keyValues[s[i]];
                }
            }

            return nNumeral + keyValues[s[s.Length - 1]];
        }

    }
}
