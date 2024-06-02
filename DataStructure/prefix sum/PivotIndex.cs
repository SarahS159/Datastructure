using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.prefix_sum
{
    public class PivotIndex
    { //THE MOST EFFIECINT SOLUTION SPACE O(1), TIME O(N)
        public int FindPivotIndex(int[] nums)
        {
            int totalSum = 0;
            int leftSum = 0;

            // Calculate the total sum of the array
            foreach (int num in nums)
            {
                totalSum += num;
            }

            // Iterate through the array to find the pivot index
            for (int i = 0; i < nums.Length; i++)
            {
                // rightSum is calculated as totalSum - leftSum - nums[i]
                // If leftSum == rightSum, then we found the pivot index
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }
                // Update leftSum for the next iteration
                leftSum += nums[i];
            }

            // If no pivot index is found, return -1
            return -1;

            

        }

    }
}
//MY SOLUTION: SPACE O(N), TIME O(N)
/*int[] sumRights = new int[nums.Length];
            sumRights[nums.Length - 1] = 0;

            int[] sumLefts = new int[nums.Length];
            sumLefts[0] = 0;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                sumRights[i] = nums[i + 1] + sumRights[i + 1];
            }
            for (int i = 1; i < nums.Length; i++)
            {
                sumLefts[i] = nums[i - 1] + sumLefts[i - 1];
            }

            int pivot = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (sumRights[i] == sumLefts[i])
                    pivot = i;
            }

            return pivot;*/
