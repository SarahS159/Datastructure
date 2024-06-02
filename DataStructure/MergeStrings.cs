using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MergeStrings
    {
        public string MergeAlternately(string word1, string word2)
        {
            var appendedString = GetAppendedString(word1, word2); 
            var resultArrayLength = (word1.Length + word2.Length) - appendedString.Length;
            var resultedString = string.Empty;

            for (int i = 0; i < resultArrayLength; i++)
            {
                if (i % 2 == 0)
                {
                    resultedString += word1.Substring(0, 1);
                    word1 = word1.Remove(0, 1);

                }

                else
                {
                    resultedString += word2.Substring(0, 1);
                    word2 = word2.Remove(0, 1);
                }
            }
            return resultedString + appendedString;
        }

        public string GetAppendedString(string word1, string word2)
        {
            var appendedString = string.Empty;
            if (word1.Length == word2.Length)
                return appendedString;
            
            if(word1.Length > word2.Length)
                appendedString = word1.Substring(word2.Length , word1.Length - word2.Length);
            else 
                appendedString = word2.Substring(word1.Length, word2.Length - word1.Length);

            return appendedString;
        }
    }
}
