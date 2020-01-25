using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcertFinalExam01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bandNameAndMembers = Console.ReadLine().Split(new[] { "; ","; ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
           
            string input;
            double totalTime = 0;
            while ((input = bandNameAndMembers[0]) != "start of concert")
            {
                string command = bandNameAndMembers[0];
                List<string> bands = bandNameAndMembers.Skip(1).ToList();
                if (command == "Add")
                {
                    List<string> members = bandNameAndMembers.Skip(2).ToList();
                }
                switch (command)
                {
                    case "Add":

                        break;
                    case "Play":
                        string bandName = bandNameAndMembers[1];
                        double timeOnStage = double.Parse(bandNameAndMembers[2]);
                        PlayTime(bandName, timeOnStage, bands);
                        totalTime += timeOnStage;
                        break;
                }
            }
        }

        private static void PlayTime(string bandName, double timeOnStage, List<string> bands)
        {
            if (bands.Contains(bandName))
            {
                Console.WriteLine(bandName + " " + timeOnStage);
            }
            else
            {
                bands.Add(bandName);
            }
            
        }
    }
}
