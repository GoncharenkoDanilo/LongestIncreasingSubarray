using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().Split();
            int numOfNums = Convert.ToInt32(inputStr[0]);
            int[] nums = new int[numOfNums];            

            for (int i = 0; i < numOfNums; i++)
            {
                nums[i] = Convert.ToInt32(inputStr[i+1]);
            }

            Console.Write(findLongestIncreasingSubarray(nums));
            Console.Read();

        }

        static int findLongestIncreasingSubarray(int[] nums)
        {
            int longest = 1;
            int temp = 1;

            if (nums.Length == 0)
                return 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    temp++;
                else
                {
                    if (temp > longest)
                        longest = temp;
                    temp = 1;
                }
            }

            if (temp > longest)
                longest = temp;

            return longest;

        }
    }
}
