using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLeetCode
{
    internal class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int) Math.Pow(nums[i] , 2);
            }
            Array.Sort(nums);
            return nums;
        }
    }
}
