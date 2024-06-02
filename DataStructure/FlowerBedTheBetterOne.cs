using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;
            if (flowerbed.Length == 1 && flowerbed[0] == 1)
                return false;
            if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1)
                return true;

            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                n = n - 1;
            }
            if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
            {
                flowerbed[flowerbed.Length - 1] = 1;
                n = n - 1;
            }
            int i = 1;
            while (i < flowerbed.Length - 1 && n > 0)
            {
                if (flowerbed[i] == 1)
                {
                    i = i + 2;
                    continue;
                }
                else if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n = n - 1;
                    i = i + 2;
                }
                else
                    i = i + 1;
            }
            if (n <= 0)
                return true;
            else
                return false;

        }
    }
}
