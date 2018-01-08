using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace MegaChallengeWar
{
    public class Deck
    {
      
        private List<Card> _deck;
        private Random _random;
        private StringBuilder _sb;

        public Deck()
        {
            _deck = new List<Card>();
            _random = new Random();
            _sb = new StringBuilder();
            
            string[] suits = new string[] { "Clubs", "Hearts", "Spades", "Dimonds" };
            string[] kinds = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var kind in kinds)
                {
                    _deck.Add(new Card() { Suits = suit, Kinds = kind }); 
                }

            }
        }
        public string Deal(Players player1, Players player2)
        {
            
          //  Card card = _deck.ElementAt(_random.Next(_deck.Count));
            while (_deck.Count > 0)
            {
                 playerDeal(player1);
                 playerDeal(player2);
               

             }
            return  _sb.ToString();
        }

         private void playerDeal (Players player)
         {
             Card card = _deck.ElementAt(_random.Next(_deck.Count));

             player.Cards.Add(card);
             _deck.Remove(card);

             _sb.Append("<br />");
             _sb.Append(player.PlayerName);
             _sb.Append(" is dealt with ");
             _sb.Append(card.Suits);
             _sb.Append(" ");
             _sb.Append(card.Kinds);

         }
    }
}