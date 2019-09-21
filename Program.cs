using System;

namespace SusanaTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            Print1To10();
            PrintPairs();
            PrintPairsWithArgument(20, 40);
            PrintPairsWithArgument(21, 41);
            SumWhileLessThan(5000);
            SumWhileLessThan(7800);
            SumWhileLessThan(7800000);

            Console.WriteLine("Please press a key to exit...");
            Console.ReadKey();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();
        }

        static void Print1To10()
        {
            Console.WriteLine("Print1To10");

            for(var num = 0; num <= 10; num++)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }

        static void PrintPairs()
        {
            Console.WriteLine("PrintPairs");

            for(var num = 2; num <= 10; num += 2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }

        static void PrintPairsWithArgument(int from, int to)
        {
            Console.WriteLine("PrintPairsWithArgument");

            //for(var num = from; num <= to; num += 2)
            //{
            //    Console.WriteLine(num);
            //}

            //for (var num = from; num <= to; num++)
            //{
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            if (from % 2 == 1)
            {
                from += 1;
            }

            for(var num = from; num <= to; num += 2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }

        static void SumWhileLessThan(int limit)
        {
            var sum = 0;
            var number = 1;

            while(sum < limit)
            {
                sum += number++;
            }

            Console.WriteLine(sum);
        }
    }
}
