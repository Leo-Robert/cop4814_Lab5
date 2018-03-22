using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Game
    {
        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string Score1 { get; set; }

        public string Score2 { get; set; }
        //default constructor
        public Game()
        {

        }
        //parameter constructor
        public Game(string team1, string team2, string score1, string score2)
        {
            Team1 = team1;

            Team2 = team2;

            Score1 = score1;

            Score2 = score2;
        }

        public override string ToString()
        {

            string text = Team1 + " " + "(" + Score1 + ")\t\t" + Team2 + " " + "(" + Score2 + ")";

            return text;
        }

    }
}
