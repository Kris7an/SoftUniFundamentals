using System;
using System.Collections.Generic;
using System.Linq;

namespace kur
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { " =", "#"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double water = double.Parse(Console.ReadLine());

            Dictionary<double, string> status = AddToDick(input);

            double totalFires;
            
            List<double> realFires;
           
            realFires = WaterCount(water, status);
            
            Console.WriteLine("Cells:");
            totalFires = RealFiresGet(realFires);
            
            double effort = totalFires * 0.25;
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFires:f0}");
           
        }

       

        private static Dictionary<double, string> AddToDick(string[] input)
        {
            Dictionary<double, string> status = new Dictionary<double, string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    status.Add(Convert.ToDouble(input[i + 1]), input[i]);
                }
            }
            return status;
        }

        private static double RealFiresGet(List<double> realFires)
        {
            double totalFires2 = 0;
            foreach (var item2 in realFires)
            {
                Console.WriteLine($"- {item2}");
                totalFires2 += item2;
            }
            return totalFires2;
        }

        private static List<double> WaterCount(double water, Dictionary<double, string> status)
        {
            
                List<double> realFires = new List<double>();
            
            foreach (var item in status)
            {
                if (item.Value == "High" && item.Key >= 81 && item.Key <= 125)
                {
                    if (item.Key <= water)
                    {
                        water -= item.Key;
                        realFires.Add(item.Key);
                    }
                }
                else if (item.Value == "Medium" && item.Key >= 51 && item.Key <= 80)
                {
                    if (item.Key <= water)
                    {
                        water -= item.Key;
                        realFires.Add(item.Key);
                    }
                }
                else if (item.Value == "Low" && item.Key >= 1 && item.Key <= 50)
                {
                    if (item.Key <= water)
                    {
                        water -= item.Key;
                        realFires.Add(item.Key);
                    }
                }
            }
                return realFires;
        }
    }
}

