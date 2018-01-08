using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        /*private Players _player1;
       private Players _player2;

      public Game(string Player1Name, string Player2Name)
       {
           _player1 = new Players() { PlayerName = Player1Name };
           _player2 = new Players() { PlayerName = Player2Name };
       }*/
        public string Play()
        {
            Players player1 = new Players();
            Players player2 = new Players();
            player1.PlayerName = "Player1";
            player2.PlayerName = "Player2";

            Deck deck = new Deck();
            string result = deck.Deal(player1, player2);
            result += detemindWinner(player1,player2);
            return result;
            
        }

        private string detemindWinner(Players player1, Players player2)
        {
           
                string result = "";
                int round = 0;
            int player1CardAmount = 0;
            int player2CardAmount = 0;


            while (player1.Cards.Count != 0 && player2.Cards.Count != 0)
                {

                    Card player1Card = player1.Cards.ElementAt(0);
                    Card player2Card = player2.Cards.ElementAt(0);

               
                if (player1Card.CardValue() > player2Card.CardValue())
                    {
                        player1CardAmount = player1.Cards.Count+1 ;
                        player2CardAmount = player2.Cards.Count-1;

                    }
                    else
                    {
                        player2CardAmount = player2.Cards.Count+1;
                        player1CardAmount = player1.Cards.Count-1;
                    
                    }

                       round++;
                       if (round > 20)
                        break;
                    }
            if (player1CardAmount > player2CardAmount)
                result += "<br />Player1 wins." + " " + "Player1 has " + player1CardAmount + " cards" +
                    "<br />Player2 has " + player2CardAmount + "cards";
            else
                result += "<br />Player2 wins." + " " + "Player2 has " + player2CardAmount + " cards" +
                     "<br />Player1 has " + player1CardAmount + "cards"; ;


          return result;

            }
        }
    }

    

