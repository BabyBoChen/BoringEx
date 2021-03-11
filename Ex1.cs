using System;

namespace exercise
{
    class Ex1
    {
        static void Main()
        {
            Ex1.ex1();
            Ex2.ex2();
            Ex3.ex3();
            Ex4.ex4();
        }
        
        static void ex1()
        {
           var a = ArithmeticSeriesWhile(1,99,2);
           Console.WriteLine(a);
           var b = ArithmeticSeriesFor(1,99,2);
           Console.WriteLine(b);
        }
        static int ArithmeticSeriesWhile(int firstNumber, int lastNumber, int diff)
        {
            
            if (firstNumber >= lastNumber)
            {
                throw new Exception("The last number should be greater than the first number!");
            };
            var currentNum = firstNumber;
            var sum = 0;
            while (currentNum <= lastNumber)
            {
                try
                {
                    sum = checked(sum+currentNum);
                    currentNum += diff;
                }
                catch (OverflowException of)
                {
                    Console.WriteLine("stack overflow!!!");
                    return 0;
                }
            }
            return sum;
        }
        static int ArithmeticSeriesFor(int firstNumber, int lastNumber, int diff)
        {
            if (firstNumber >= lastNumber)
            {
                throw new Exception("The last number should be greater than the first number!");
            };
            var sum = 0;
            for (int i = firstNumber; i <= lastNumber; i += diff )
            {
                try
                {
                    sum = checked(sum+i);
                }
                catch (OverflowException of)
                {
                    Console.WriteLine("stack overflow!!!");
                    return 0;
                }
            }
            return sum;
        }
    }
}
