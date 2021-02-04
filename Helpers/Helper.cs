using System;
using System.Linq;
using DiscoverKiller.Exceptions;

namespace DiscoverKiller.Helpers
{
    public static class Helper
    {
        public static void ProcessHyphotese(string[] hypothese)
        {
            if (hypothese.Contains("0"))
            {
                throw new DomainException("I don't recognize the hypothesis informed with value 0.");
            }

            if (hypothese.Length > 3)
            {
                throw new DomainException("Just can there three hypotheses: Suspects, Locations and Weapons.");
            }
        }
    }
}
