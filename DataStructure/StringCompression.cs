using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class StringCompression
    {
        public int Compress(char[] chars)
        {
            int n = 1;
            var s = new StringBuilder();
            var currentIndex = 0;
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == chars[currentIndex])
                    n++;
                if (chars[i] != chars[currentIndex])
                {
                    if (n > 1)
                    {
                        s.Append(chars[currentIndex]).Append(n);
                        currentIndex = i;
                        n = 1;
                    }
                    else
                    {
                        s.Append(chars[currentIndex]);
                        currentIndex = i;
                        n = 1;
                    }
                }
            }
            if (n > 1)
                s.Append(chars[currentIndex]).Append(n);
            else
                s.Append(chars[currentIndex]);

            string res = s.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                chars[i] = res[i];
            }
            return s.Length;
        }


    }
    
}
