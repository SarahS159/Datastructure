using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //TODO: Two pointers problem.
    public class MoveZeroes
    {
        public void Move(int[] nums)
        {
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    (nums[left], nums[right]) = (nums[right], nums[left]);
                    left++;
                }
            }
        }

    }
}
//this one was faster...
/*  public void Move(int[] nums)
            {
                int i = 0;
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] == 0 && nums[j] != 0)
                    {
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        i++;
                    }
                    else if (nums[i] != 0)
                        i++;
                    else
                        continue;
                }
            }*/