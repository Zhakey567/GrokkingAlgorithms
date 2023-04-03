using System.Runtime.CompilerServices;

namespace GrokkingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 1, 0, 1, 1, 1 };
            var a = FindMaxConsecutiveOnes(arr);
            Console.WriteLine(a);
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            var count = 0;
            var maxCount = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    count++;
                else if (count > maxCount)
                {
                    maxCount = count;
                    count = 0;
                }
                else
                    count = 0;
                if (i == nums.Length - 1 && count > maxCount)
                {
                    maxCount = count;
                }
            }
            return maxCount;
        }//1 1 0 1 1 1
    }
}