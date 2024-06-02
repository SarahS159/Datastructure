using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    //TODO: Memorize this really well : k * 10 + (s[i] - '0') to build digit.
    public class DecodeString
    {
        public string Decode(string s)
        {
            Stack<int> countStack = new Stack<int>();
            Stack<StringBuilder> stringStack = new Stack<StringBuilder>();
            StringBuilder currentString = new StringBuilder();
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    k = k * 10 + (s[i] - '0');
                }
                else if (s[i] == '[')
                {
                    countStack.Push(k);
                    stringStack.Push(currentString);
                    currentString = new StringBuilder();
                    k = 0;
                }
                else if (char.IsLetter(s[i]))
                {
                    currentString.Append(s[i]);
                }
                else if (s[i] == ']')
                {
                    int repeatTimes = countStack.Pop();
                    StringBuilder decodedString = stringStack.Pop();
                    for (int j = 0; j < repeatTimes; j++)
                    {
                        decodedString.Append(currentString);
                    }
                    currentString = decodedString;
                }
            }

            return currentString.ToString();
        }
    }
}

