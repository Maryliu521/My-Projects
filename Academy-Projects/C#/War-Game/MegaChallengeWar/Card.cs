using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Card
    {
        public string Suits { get; set; }
        public string Kinds { get; set; }

        public int CardValue()
        {
            int value = 0;
            switch (this.Kinds)
            {
                case "Jack":
                    value = 11;
                    break;
                case "Queen":
                    value = 12;
                    break;
                case "King":
                    value = 13;
                    break;
                case "Ace":
                    value = 14;
                    break;
                default:
                    value = int.Parse(this.Kinds);
                    break;
                  

            }
            return value;
        }

    }
}