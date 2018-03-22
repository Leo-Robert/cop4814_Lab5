//this is step 7 of lab 7 
//i added in this comment...
//comment
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is step 10 of lab 7...
//i am adding a comment from the master branch...
namespace Lab2
{
    public class Game
    {
        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string Score1 { get; set; }

        public string Score2 { get; set; }
        //this is step 11 in lab 7...
        //this comment was added from the master branch...
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
        //this is step 10 in lab 7...
        //i am adding this comment from branch_1
        public override string ToString()
        {

            string text = Team1 + " " + "(" + Score1 + ")\t\t" + Team2 + " " + "(" + Score2 + ")";

            return text;
        }
        //this is step 11 of lab 7...
        //this comment was added in banch_1...
    }
}
//master
