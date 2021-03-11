using System;

namespace exercise
{
    class Ex3
    {
        public static void ex3()
        {
            int[] nums = {44,66,99, 100, 78};
            var max = MaxScore(nums);
            var min = MinScore(nums);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        static int MaxScore(int[] nums)
        {
            if(nums.Length < 1)throw new Exception("Don't fuck with me!");
            int max;
            max = nums[0];
            foreach(var num in nums)
            {
                if(num>max)max = num;
            }
            return max;
        }
        static int MinScore(int[] nums)
        {
            if(nums.Length < 1)throw new Exception("Don't fuck with me!");
            int min;
            min = nums[0];
            foreach(var num in nums)
            {
                if(num<min)min = num;
            }
            return min;
        }
    }
}