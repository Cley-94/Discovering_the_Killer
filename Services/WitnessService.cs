using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiscoverKiller.Contracts;
using DiscoverKiller.Extensions;
using DiscoverKiller.Helpers;

namespace DiscoverKiller.Services
{
    public class WitnessService 
    {
        private string[] SolvedCase;
        private List<string> auxListSolvedCase = new List<string>();
        public string Message { get; private set; }
        public IHypothesesService _hypothesesService;

        public WitnessService(IHypothesesService hypothesesService)
        {
            _hypothesesService = hypothesesService;
        }

        public void FindSuspects()
        {
            Random random = new Random();
            string suspectedName = random.Next(_hypothesesService.GetSuspects().Length).ToString();
            suspectedName = VerifySetHyphoteseInArrayWhenValueIsZero(suspectedName);
            auxListSolvedCase.Add(suspectedName);
            SolvedCase = auxListSolvedCase.ToArray();
        }

        public void FindLocations()
        {
            Random random = new Random();
            string suspectedLocation = random.Next(_hypothesesService.GetSuspects().Length).ToString();
            suspectedLocation = VerifySetHyphoteseInArrayWhenValueIsZero(suspectedLocation);
            auxListSolvedCase.Add(suspectedLocation);
            SolvedCase = auxListSolvedCase.ToArray();
        }

        public void FindWeapons()
        {
            Random random = new Random();
            string suspectedWeapon = random.Next(_hypothesesService.GetSuspects().Length).ToString();
            suspectedWeapon = VerifySetHyphoteseInArrayWhenValueIsZero(suspectedWeapon);
            auxListSolvedCase.Add(suspectedWeapon);
            SolvedCase = new string[] { "1", "3", "2" };//auxListSolvedCase.ToArray();
        }

        public string CheckHypotheses(string[] hypotheseInformed)
        {
            Helper.ProcessHyphotese(hypotheseInformed);

            if (hypotheseInformed.SequenceEqual(SolvedCase))
            {
                Message = "0 (Yeah, that's it! All of hypotheses are correct! You solved the case!)";
            }

            else if (!hypotheseInformed.SequenceEqual(SolvedCase))
            {
                //Tratar quando alguma hipótese, ou mais de uma hipótese está incorreta
                StringBuilder wrongHyphotesess = new StringBuilder();
                //List<string> wrongHyphoteses = new List<string>();
                for (int i = 0; i < SolvedCase.Length; i++)
                {
                    if(SolvedCase[i] != hypotheseInformed[i])
                    {
                        wrongHyphotesess.Append(hypotheseInformed.FindIndexHypotheseArray(hypotheseInformed[i]).ToString()).ToString();
                        //wrongHyphotesess.AppendFormat("{0} ", hypotheseInformed.FindIndexHypotheseArray(hypotheseInformed[i]).ToString()).ToString();
                        //wrongHyphoteses.Add(hypotheseInformed.FindIndexHypotheseArray(hypotheseInformed[i]).ToString());
                    }
                }
                Message = wrongHyphotesess.ToString();
            }

            return Message;
        }

        public string VerifySetHyphoteseInArrayWhenValueIsZero(string hyphoteseValue)
        {
            return hyphoteseValue.Contains("0") ? "1" : hyphoteseValue;
        }

        public void FindMissing(string[] solvedCase, string[] hyphoteseValue)
        {
            HashSet<string> s = new HashSet<string>();
            for (int i = 0; i < solvedCase.Length; i++)
            {
                s.Add(hyphoteseValue[i]);
            }

            for (int i = 0; i < hyphoteseValue.Length; i++)
            {
                if (!s.Contains(solvedCase[i]))
                {
                    Console.Write(solvedCase[i] + " ");
                }
            }
        }
    }
}
