using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashSet
{
    //below one is more robust solution to avoid delete from collection while iterating over it.
    public class FindTheDifferenceBetweenTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var hashSet1 = new HashSet<int>(nums1);
            var hashSet2 = new HashSet<int>(nums2);

            var uniqueToNums1 = new List<int>();
            var uniqueToNums2 = new List<int>();

            foreach (var item in nums1)
            {
                if (!hashSet2.Contains(item))
                {
                    uniqueToNums1.Add(item);
                }
            }

            foreach (var item in nums2)
            {
                if (!hashSet1.Contains(item))
                {
                    uniqueToNums2.Add(item);
                }
            }

            return new List<IList<int>> { uniqueToNums1, uniqueToNums2 };
        }


    }
}
//this is my solution has this note:
/* it has a critical flaw: modifying a collection while iterating over it can cause unexpected behavior and exceptions. 
Specifically, removing items from a HashSet while iterating over it will lead to an InvalidOperationException*/

/*  public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
       var hashSet1 = new HashSet<int>(nums1);
       var hashSet2 = new HashSet<int>(nums2);

        foreach(var item in hashSet1)
            {
           if(hashSet2.Contains(item)){
                 hashSet1.Remove(item); 
                 hashSet2.Remove(item); 
           }
                
       
        }
        var result = new List<IList<int>>();
        result.Add(hashSet1.ToList());
        result.Add(hashSet2.ToList());
        return result;
    }*/
