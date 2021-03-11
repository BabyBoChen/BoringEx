using System;

namespace exercise
{
    class Ex4
    {
        public static void ex4()
        {
            int[] nums = {44,66,99, 100, 78};
            var odds = FindOdds(nums);
            var evens = FindEvens(nums);
            Console.WriteLine(odds.Length);
            Console.WriteLine(evens.Length);
        }

        static int[] FindOdds(int[] nums)
        {
            if(nums.Length < 1)throw new Exception("Don't fuck with me!");
            var oddsCount = 0;
            foreach(var num in nums)
            {
                if(num%2==1)oddsCount += 1;
            }
            int[] odds = new int[oddsCount];
            var tempIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]%2==1)
                {
                    odds[tempIndex] = nums[i];
                    tempIndex++;
                }
            }
            return odds;
        }

        static int[] FindEvens(int[] nums)
        {
            if(nums.Length < 1)throw new Exception("Don't fuck with me!");
            var evensCount = 0;
            foreach(var num in nums)
            {
                if(num%2==0)evensCount += 1;
            }
            int[] evens = new int[evensCount];
            var tempIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]%2==0)
                {
                    evens[tempIndex] = nums[i];
                    tempIndex++;
                }
            }
            return evens;
        }
    }
}