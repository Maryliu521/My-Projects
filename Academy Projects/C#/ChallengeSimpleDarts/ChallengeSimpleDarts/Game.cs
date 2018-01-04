using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {   private Player _player1;
        private Player _player2;
        private Random _random;


      
     public Game(string player1Name, string player2Name)
        {
            _player1 = new Player();
            _player1.PlayerName = player1Name;
            _player2 = new Player();
            _player2.PlayerName = player2Name;
            _random = new Random();

        }
        public string Play()
        {
            while (_player1.Score < 300 && _player2.Score < 300)
            {
                PlayRound(_player1);
                PlayRound(_player2);
            }
            return displayResult();
        }

        private string displayResult()
        {
            string result = string.Format("{0}:{1}<br />{2}: {3}<br/>",
                _player1.PlayerName, _player1.Score,
                _player2.PlayerName, _player2.Score);
            return result += "Winner is " + 
                (_player1.Score > _player2.Score ? _player1.PlayerName : _player2.PlayerName);
        }

        private void PlayRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDarts(player, dart);
            }
        }
    }
}