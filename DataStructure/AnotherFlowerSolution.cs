using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Solution2
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;
            if (flowerbed.Length == 1 && flowerbed[0] == 1)
                return false;
            if (flowerbed.Length == 1 && flowerbed[0] == 0 && n <= 1)
                return true;

            int i = 1;
            while (i < flowerbed.Length && n > 0)
            {

                if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && i == 1)
                {
                    flowerbed[i - 1] = 1;
                    n = n - 1;
                }
                else if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && i == flowerbed.Length - 1)
                {
                    flowerbed[i] = 1;
                    n = n - 1;
                }
                else if (flowerbed[i] == 0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n = n - 1;
                }

                i = i + 1;
            }
            if (n <= 0)
                return true;
            else
                return false;

        }
    }


}
