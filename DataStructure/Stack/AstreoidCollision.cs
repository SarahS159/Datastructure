using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class AstreoidCollision
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            List<int> newList = new List<int>();
            int sitem = asteroids[asteroids.Length - 1];
            for (int i = 0; i < asteroids.Length - 1; i++)
            {
                stack.Push(asteroids[i]);
            }


            while (stack.Count > 0)
            {
                if (sitem < 0 && stack.Peek() > 0)
                {
                    if (Math.Abs(sitem) < stack.Peek())
                    {
                        sitem = stack.Pop();
                    }
                    else if (Math.Abs(sitem) == stack.Peek())
                    {
                        stack.Pop();
                        sitem = stack.Count > 0 ? stack.Pop() : 0;
                    }
                    else
                        stack.Pop();
                }
                else
                {
                    newList.Add(sitem);
                    sitem = stack.Count > 0 ? stack.Pop() : 0;
                }
            }

            if(sitem !=0)
            newList.Add(sitem);
            if (stack.Count > 0)
            {
                newList.Add(stack.Pop());
            }
            newList.Reverse();
            return newList.ToArray();

        }
    }
}
