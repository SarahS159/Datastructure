
namespace DataStructure
{
    public class SubsequenceString
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length)
                return false;
            int tCounter = 0;
            int sCounter = 0;
            while (sCounter < s.Length && tCounter < t.Length)
            {
                if (t[tCounter] == s[sCounter])
                {
                    sCounter++;
                    tCounter = tCounter + 1;
                }
                else
                    tCounter++;
            }
        
            return sCounter == s.Length;
        }

    }

}
