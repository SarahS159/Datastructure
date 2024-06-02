using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class KidsWithCandy
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            
            var orderedArray = candies.Order();
            var greatest = orderedArray.Last();
            var output = new List<bool>();  

            
            for (var i= 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= greatest)
                    output[i] = true;   
                else output[i] = false;
            }
            return output;

            
        }
    }
}
