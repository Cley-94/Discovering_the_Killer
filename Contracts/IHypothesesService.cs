using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverKiller.Contracts
{
    public interface IHypothesesService
    {
        string[] GetSuspects();
        string[] GetLocations();
        string[] GetWeapons();
    }
}
