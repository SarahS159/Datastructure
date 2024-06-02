using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxWater = 0;
            int i = 0;
            int j = height.Length - 1;

            while (j - i != 0)
            {
                var temp = (j - i) * Math.Min(height[j], height[i]);
                if (temp > maxWater)
                    maxWater = temp;

                if (height[i] >= height[j])
                    j--;
                else
                    i++;
            }
            return maxWater;
        }
    }
}
