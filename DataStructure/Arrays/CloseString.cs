using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Arrays
{
    internal class CloseString
    {
        public bool CloseStrings(string word1, string word2)
        {
            // If the lengths of the two strings are different, they cannot be "close".
            if (word1.Length != word2.Length)
            {
                return false;
            }

            // Create frequency arrays for both strings
            int[] freq1 = new int[26];
            int[] freq2 = new int[26];

            // Count the frequency of each character in both strings
            for (int i = 0; i < word1.Length; i++)
            {
                freq1[word1[i] - 'a'] += 1;
                freq2[word2[i] - 'a'] += 1;
            }

            // Check if both strings have the same set of characters
            for (int i = 0; i < 26; i++)
            {
                if ((freq1[i] != 0 && freq2[i] == 0) || (freq1[i] == 0 && freq2[i] != 0))
                {
                    return false;
                }
            }

            // Sort the frequency arrays
            Array.Sort(freq1);
            Array.Sort(freq2);

            // Compare the sorted frequency arrays
            for (int i = 0; i < 26; i++)
            {
                if (freq1[i] != freq2[i])
                {
                    return false;
                }
            }

            // If all checks passed, the strings are "close"
            return true;
        }
    }

}

