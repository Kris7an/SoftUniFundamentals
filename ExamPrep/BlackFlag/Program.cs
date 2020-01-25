using System;
using System.Collections.Generic;
using System.Linq;
namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            //int daysOfPlunder = int.Parse(Console.ReadLine());
            //int dailyPlunder = int.Parse(Console.ReadLine());
            //double expectedPlunder = double.Parse(Console.ReadLine());


            //double totalPlunder = 0;
            //for (int i = 1; i <= daysOfPlunder; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        totalPlunder += dailyPlunder;
            //        totalPlunder += (dailyPlunder * 0.5);
            //    }
            //    else
            //    {
            //        totalPlunder += dailyPlunder;
            //    }
            //    if (i % 5 == 0)
            //    {
            //        totalPlunder -= totalPlunder * 0.3;
            //    }
            //}
            //double leftPrecentage = (totalPlunder / expectedPlunder) * 100;
            //if (totalPlunder >= expectedPlunder)
            //{
            //    Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            //}
            //else
            //{
            //    Console.WriteLine($"Collected only {leftPrecentage:f2}% of the plunder.");
            //}

            int a = 0;
            string something = "gabi e guska";

            DoSomething(a, something);


        }

        private static void DoSomething(int a, string something)
        {
            int x = 0;

            for (int i = 0; i < something.Length; i++)
            {
                x += something[i];
            }
            a += x;
            Console.WriteLine(a);

           
            
        }
    }
}
