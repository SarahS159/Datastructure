using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //for this problem we can use stacks since in stack last in first out but in that case we will need 2 for loops (not inside each other) but still, for large strings will b
    //less efficient than this solution.
    public class ReverseVowlesOfString
    {
        public string ReverseVowels(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //var sArray = s.ToCharArray(); //is sooo better to use stringBuilder instead of  //char array
            StringBuilder sb = new StringBuilder(s);
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (vowels.Contains(s[i]) && vowels.Contains(s[j]))
                {
                    var temp1 = sb[i];
                    sb[i] = sb[j];
                    sb[j] = temp1;
                    i++;
                    j--;
                }
                else if (!vowels.Contains(s[i]) && vowels.Contains(s[j]))
                    i++;
                else if (vowels.Contains(s[i]) && !vowels.Contains(s[j]))
                    j--;

                else
                {
                    i++;
                    j--;
                }
            }
            return sb.ToString();
        }
    }
}
