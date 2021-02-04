using System;
using System.Linq;
using DiscoverKiller.Exceptions;
using DiscoverKiller.Services;

namespace DiscoverKiller
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WitnessService witnessService = new WitnessService(new HypothesesService());

                witnessService.FindSuspects();
                witnessService.FindLocations();
                witnessService.FindWeapons();

                DetectiveService detectiveService = new DetectiveService(new HypothesesService());

                Console.WriteLine("Bill was assassinated and I have a theory that can solve this case. ");
                Console.WriteLine("I think you can help me to solve the enigma.Those are the possibles suspects, locations and weapons of crime:");

                Console.WriteLine();

                detectiveService.ListSuspects();

                Console.WriteLine();
                Console.Write("I have a theory of who could have assassinated Bill. G. Ates: ");
                string[] theory = Console.ReadLine().Replace(" ", string.Empty).Split(",");

                if (Console.BackgroundColor == ConsoleColor.Black)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(witnessService.CheckHypotheses(theory));
                }
                Console.ResetColor();
            }
            catch (DomainException de)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Error: " + de.Message);
                Console.ResetColor();
            }
        }
    }
}
