using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void ScoreDarts (Player player, Dart dart)
        {
            int score = 0;
            if (dart.IsDouble) score = dart.Score * 2;
           else if (dart.IsTriple) score = dart.Score * 3;

            if (dart.IsTriple && dart.Score == 0) score = 50;
            else if (dart.IsDouble)score = 25;
            player.Score += score; 

        }
    }
}