using DiscoverKiller.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverKiller.Services
{
    public class HypothesesService : IHypothesesService
    {
        //#region hypothesesList
        //List<string> suspects = new List<string>()
        //{
        //    { "Charles B.Abbage" },
        //    { "Donald Duck Knuth" },
        //    { "Ada L. Ovelace" },
        //    { "Alan T. Uring" },
        //    { "Ivar J. Acobson" },
        //    { "Ras Mus Ler Dorf" }
        //};

        //List<string> locations = new List<string>()
        //{
        //    { "Redmond" },
        //    { "Palo Alto" },
        //    { "San Francisco" },
        //    { "Tokio" },
        //    { "Restaurante no Fim do Universo" },
        //    { "São Paulo" },
        //    { "Cupertino" },
        //    { "Helsinki" },
        //    { "Maida Vale" },
        //    { "Toronto" }
        //};

        //List<string> weapons = new List<string>()
        //{
        //    { "Peixeira" },
        //    { "DynaTAC 8000X" },
        //    { "Trezoitão" },
        //    { "Trebuchet" },
        //    { "Maça" },
        //    { "Gládio" }
        //};
        //#endregion

        //#region hypotheses
        //Dictionary<int, string> suspects = new Dictionary<int, string>()
        //{
        //    { 1, "Charles B.Abbage" },
        //    { 2, "Donald Duck Knuth" },
        //    { 3, "Ada L. Ovelace" },
        //    { 4, "Alan T. Uring" },
        //    { 5, "Ivar J. Acobson" },
        //    { 6, "Ras Mus Ler Dorf" }
        //};

        //Dictionary<int, string> locations = new Dictionary<int, string>()
        //{
        //    { 1, "Redmond" },
        //    { 2, "Palo Alto" },
        //    { 3, "San Francisco" },
        //    { 4, "Tokio" },
        //    { 5, "Restaurante no Fim do Universo" },
        //    { 6, "São Paulo" },
        //    { 7, "Cupertino" },
        //    { 8, "Helsinki" },
        //    { 9, "Maida Vale" },
        //    { 10, "Toronto" }
        //};

        //Dictionary<int, string> weapons = new Dictionary<int, string>()
        //{
        //    { 1, "Peixeira" },
        //    { 2, "DynaTAC 8000X" },
        //    { 3, "Trezoitão" },
        //    { 4, "Trebuchet" },
        //    { 5, "Maça" },
        //    { 6, "Gládio" }
        //};
        //#endregion

        #region hypothesesVectors
        string[] suspects = new string[6] 
        {
            "Charles B.Abbage" ,
            "Donald Duck Knuth" ,
            "Ada L. Ovelace" ,
            "Alan T. Uring",
            "Ivar J. Acobson",
            "Ras Mus Ler Dorf"
        };

        string[] locations = new string[10]
        {
            "Redmond",
            "Palo Alto",
            "San Francisco",
            "Tokio",
            "Restaurante no Fim do Universo",
            "São Paulo",
            "Cupertino",
            "Helsinki",
            "Maida Vale",
            "Toronto"
        };

        string[] weapons = new string[6]
        {
             "Peixeira" ,
             "DynaTAC 8000X",
             "Trezoitão",
             "Trebuchet",
             "Maça",
             "Gládio"
        };
        #endregion

        public string[] GetSuspects()
        {
            return suspects;
        }

        public string[] GetLocations()
        {
            return locations;
        }

        public string[] GetWeapons()
        {
            return weapons;
        }
    }
}
