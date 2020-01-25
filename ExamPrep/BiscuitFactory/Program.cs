using System;

namespace BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsADay = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int biscuitsCompetitor = int.Parse(Console.ReadLine());
            double totalBiscuitsMade = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalBiscuitsMade += Math.Floor((biscuitsADay * countWorkers) * 0.75);
                }
                else
                {
                    totalBiscuitsMade += biscuitsADay * countWorkers;
                }
            }
            double productionDiffrance = Math.Abs(totalBiscuitsMade - biscuitsCompetitor);
            double percentage = 0;

            Console.WriteLine($"You have produced {totalBiscuitsMade:f0} biscuits for the past month.");

            if (totalBiscuitsMade >= biscuitsCompetitor)
            {
                
                percentage = productionDiffrance / biscuitsCompetitor * 100;

                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                
                percentage = productionDiffrance / biscuitsCompetitor * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }

        }
    }
}
