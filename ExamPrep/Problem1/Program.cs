using System;
using System.Collections.Generic;
namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());

            //List<double> consumEnergy = new List<double>();

            double totalWater = days * countPlayers * waterPerDay;
            double totalFood = days * countPlayers * foodPerDay;


            for (int index = 1; index <= days; index++)
            {
                double energyInList = double.Parse(Console.ReadLine());
                energy -= energyInList;



                if (index % 2 == 0)
                {
                    energy += energy * 0.05;
                    totalWater = totalWater - (totalWater * 0.3);
                    Console.WriteLine(totalWater + " water");


                }
                if (index % 3 == 0)
                {
                    totalFood -= (totalFood / countPlayers);
                    energy += energy * 0.1;
                    Console.WriteLine(totalFood + " food");

                }
                Console.WriteLine(energy + "  energy");

            }

            Console.WriteLine(energy + " energy");

            Console.WriteLine(totalFood + " food");
            Console.WriteLine(totalWater + " water");
        }
    }
}
