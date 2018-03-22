using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2
{
    public class GameFactory
    {
        StreamWriter sw;

        XmlSerializer serial;

        List<Game> game = new List<Game>();

        const string FILE_PATH = (@"..\..\output.xml");

        public void CreateGameList()
        {
            //the 12 teams needed for the six games
            string team1 = "Heat";

            string team2 = "Magic";

            string team3 = "Bucks";

            string team4 = "Thunder";

            string team5 = "Suns";

            string team6 = "Knicks";

            string team7 = "Cavs";

            string team8 = "Nuggets";

            string team9 = "Gizzlies";

            string team10 = "Lakers";

            string team11 = "Nets";

            string team12 = "SuperSonics";

            string score1 = "110";

            string score2 = "120";
            //creting a new instances of Game with the teams and the score
            Game game0 = new Game(team1, team2, score1, score2);
                
            Game game1 = new Game(team3, team4, score1, score2);

            Game game2 = new Game(team5, team6, score1, score2);

            Game game3 = new Game(team7, team8, score1, score2);

            Game game4 = new Game(team9, team10, score1, score2);

            Game game5 = new Game(team11, team12, score1, score2);
            //adding those 6 games to the list of games
            //game 1
            game.Add(game0);
            //game 2
            game.Add(game1);
            //game 3
            game.Add(game2);
            //game 4
            game.Add(game3);
            //game 5
            game.Add(game4);
            //game 6
            game.Add(game5);
        }

        public void SerializeGameList()
        {
            //code needed for XML file
            serial = new XmlSerializer(game.GetType());
            sw = new StreamWriter(FILE_PATH);
            serial.Serialize(sw, game);
            sw.Close();
        }

        public List<Game> DeserializeGameList()
        {
            //read in the data from the xml
            try
            {
                List<Game> foo = new List<Game>();

                StreamReader sr = new StreamReader(FILE_PATH);

                serial = new XmlSerializer(game.GetType());

                foo = (List<Game>)serial.Deserialize(sr);

                sr.Close();

                return foo;
            }
            catch(Exception ex)
            {
                return null;
            }


        }


    }
}
