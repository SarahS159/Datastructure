using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sliding_window
{
    internal class MaxVowelInSubstring
    {
            public int MaxVowels(string s, int k)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                int maxCount = 0;
                int countInWindow = 0;

                // Initialize the first window
                for (int i = 0; i < k; i++)
                {
                    if (vowels.Contains(s[i]))
                    {
                        countInWindow++;
                    }
                }

                maxCount = countInWindow;

                // Slide the window from left to right
                for (int i = k; i < s.Length; i++)
                {
                    if (vowels.Contains(s[i]))
                    {
                        countInWindow++;
                    }
                    if (vowels.Contains(s[i - k]))
                    {
                        countInWindow--;
                    }
                    maxCount = Math.Max(maxCount, countInWindow);
                }

                return maxCount;
            }

        
    }
}
