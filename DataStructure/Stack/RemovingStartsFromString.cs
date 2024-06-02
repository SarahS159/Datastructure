using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class RemovingStartsFromString
    {
        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var item in s)
            {
                if (item == '*')
                {


                    if (stack.Count > 0)
                    {
                        stack.Pop(); // Safe to pop because we checked the count
                    }
                }
                else
                    stack.Push(item);
            }

            StringBuilder newString = new StringBuilder(stack.Count);
            while (stack.Count > 0)
            {
                newString.Append(stack.Pop());
            }

            // Reverse the string built by the stack
            char[] resultArray = newString.ToString().ToCharArray();
            Array.Reverse(resultArray);

            return new string(resultArray);
            
        }
    }
}
