using System;
using DiscoverKiller.Contracts;

namespace DiscoverKiller.Services
{
    public class DetectiveService
    {
        private IHypothesesService _hypothesesService;

        public DetectiveService(IHypothesesService hypothesesService)
        {
            _hypothesesService = hypothesesService;
        }

        public void ListSuspects()
        {
            int countItems = 1;

            var suspects = _hypothesesService.GetSuspects();
            var locations = _hypothesesService.GetLocations();
            var weapons = _hypothesesService.GetWeapons();

            Console.WriteLine("These are the suspects of crime:");
            for (int i = 0; i < suspects.Length; i++)
            {
                Console.WriteLine("{0}. {1}", countItems++, suspects[i]);
            }

            Console.WriteLine();
            countItems = 1;
            Console.WriteLine("These are the possible locations of crime:");
            for (int i = 0; i < locations.Length; i++)
            {
                Console.WriteLine("{0}. {1}", countItems++, locations[i]);
            }

            Console.WriteLine();
            countItems = 1;
            Console.WriteLine("These are the possible weapons of crime:");
            for (int i = 0; i < weapons.Length; i++)
            {
                Console.WriteLine("{0}. {1}", countItems++, weapons[i]);
            }
        }
    }
}
