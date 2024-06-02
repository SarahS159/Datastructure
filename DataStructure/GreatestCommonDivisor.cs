using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class GreatestCommonDivisor
    {
        public string Find(string str1, string str2)
        {
            var result = string.Empty;
            if (str1 + str2 != str2 + str1)
                return string.Empty;

            var answer = gcd(str1.Length, str2.Length);
            result = str1.Substring(0, answer);

            return result;

        }

        public int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }

}
