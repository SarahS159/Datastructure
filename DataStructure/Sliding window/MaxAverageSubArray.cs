using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class MaxAverageSubArray
    {

        public double FindMaxAverage(int[] nums, int k)
        {


            if (nums.Length < k)
            {
                throw new Exception("the length of the array is less than the window size.");
            }
            // Compute the sum of the first window
            double maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                maxSum += nums[i];
            }
            double sumWindow = 0;
            sumWindow = maxSum;
            for (int i = k; i < nums.Length; i++)
            {
                sumWindow = sumWindow + nums[i] - nums[i - k];
                maxSum = Math.Max(sumWindow, maxSum);
            }

            return maxSum / k;

        }

    }

}

/*static int MaxSumSubarray(int[] arr, int k)
    {
        int n = arr.Length;
        if (n < k)
        {
            throw new ArgumentException("Array length must be at least as large as the subarray size.");
        }

        int maxSum = int.MinValue;
        int windowSum = 0;

        // Calculate the sum of the first window
        for (int i = 0; i < k; i++)
        {
            windowSum += arr[i];
        }

        maxSum = windowSum;

        // Slide the window over the array and update the sum and max sum
        for (int i = k; i < n; i++)
        {
            windowSum = windowSum - arr[i - k] + arr[i];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }*/