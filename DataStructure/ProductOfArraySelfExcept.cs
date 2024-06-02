using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class ProductOfArraySelfExcept
    { 
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] prefixProducts = new int[n];
            int[] suffixProducts = new int[n];
            int[] result = new int[n];

            // Calculate prefix products
            prefixProducts[0] = 1;
            for (int i = 1; i < n; i++)
            {
                prefixProducts[i] = prefixProducts[i - 1] * nums[i - 1];
            }

            // Calculate suffix products
            suffixProducts[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                suffixProducts[i] = suffixProducts[i + 1] * nums[i + 1];
            }

            // Calculate final result
            for (int i = 0; i < n; i++)
            {
                result[i] = prefixProducts[i] * suffixProducts[i];
            }

            return result;
        }
    }
}
