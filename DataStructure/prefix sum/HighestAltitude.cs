using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.prefix_sum
{
    public class HighestAltitude
    {
      //no need for helper array
            public int LargestAltitude(int[] gain)
            {
            int max = 0;
            int sum = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                sum += gain[i];
                max = Math.Max(max, sum);
            }
            return max;

            }
        
    }
}

/*
            int[] arr = new int[gain.Length + 1];
                arr[0] = 0;
                var max = 0;
                for (int i = 0; i < gain.Length; i++)
                {
                    arr[i + 1] = arr[i] + gain[i];
                    max = Math.Max(max, arr[i + 1]);
                }
                return max;
 */