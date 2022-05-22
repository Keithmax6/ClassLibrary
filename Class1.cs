using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class Class1
    {
        public string Uppercase(string str)
        {
            string lowerCase;
            lowerCase = str.ToLower();
            string s = lowerCase;
            s = Regex.Replace(s, @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            return s;
        }

        public string VowelCount(string s)
        {
            int i, len, vowel_count;
            vowel_count = 0;
            len = s.Length;
            for (i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel_count++;
                }
            }
            return vowel_count.ToString();
        }

    }
}
