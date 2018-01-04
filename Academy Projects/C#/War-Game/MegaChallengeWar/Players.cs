using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Players
    {
        public string PlayerName { get; set; }
        public List<Card> Cards { get; set; }
        //public Deck deck = new Deck() { get; set; }

        public Players()
        {
            Cards = new List<Card>();
        }
    } 
}