using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_Cleverence_DS
{
    internal class Task1
    {

        public static string Compression(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }

            string result = string.Empty;

            char? prevChar = s[0];
            int startIndex = 1;
            for(int i = 1; i < s.Length; i++)
            { 
                if(prevChar == s[i])
                {
                    startIndex++;
                }
                else
                {
                    result += startIndex == 1 ? prevChar : $"{prevChar}{startIndex}";
                    prevChar = s[i];
                    startIndex = 1;
                }
            }

            result += startIndex == 1 ? prevChar : $"{prevChar}{startIndex}";

            return result;
        }
    }
}
