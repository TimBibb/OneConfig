using System;
using System.IO;
using System.Collections.Generic;

namespace OneConfig
{
    //TODO: make parser for each game
    public class Consolidator
    {
        static List<int> mainGames = new List<int>();
        List<List<string>> testData = new List<List<string>>();

        public Consolidator()
        {
            testData.Add(new List<string> { "mouse sens", ".25" });
            testData.Add(new List<string> { "fov", "90" });
            testData.Add(new List<string> { "divs", "432" });
            testData.Add(new List<string> { "bind e", "+forward" });
        }

        /// <summary>
        /// Setter for mainGames for the top games to pull from.
        /// </summary>
        /// <param name="games">List of most used games in order</param>
        public void SetMainGames(List<int> games){
            for (int i = 0; i < games.Count; i++){
                mainGames.Add(games[i]);
            }
			GetConfig(mainGames);
        }
        public List<int> GetMainGames(){
            return mainGames;
        }

		/// <summary>
		/// Find the games on their system
		/// </summary>
		/// <returns>the paths to the config files </returns>
		string FindGames(List<int> games)
		{
			return "";
		}

        ///On submit of main games
        ///Gets the configuration of each game and uses "parser" to
        ///parse each file and uses "AppendConfig" to add the parsed
        ///data to the "SaveData.txt" file
        private void GetConfig(List<int> games){
            for (int i = 1; i < games.Count; i++){
                switch (games[i-1])
                {
                    case 1:
                        //Insert parseBO4
                        AppendConfig(Parser.BO4("C:\\Program Files (x86)\\Call of Duty Black Ops 4\\players\\config.ini"));
                        break;
                    case 2:
                        //Insert parseBF1
                        //AppendConfig(parser.BF1());
                        break;
                    case 3:
                        //Insert parseBFV
                        //AppendConfig(parser.parseBO4());
                        break;
                    case 4:
                        //Insert parseOverwatch
                        //AppendConfig(parser.parseBO4());
                        break;
                    case 5:
                        //Insert parseCSGO...
                        //AppendConfig(parser.parseBO4());
                        break;
                    default:
                        break;
                }
            }
        }

        ///Adds the parsed data from "GetConfig" to the "SavaData.txt" file.
        ///Gives a cohesive look at the saved data from all games.
        ///Will be used in the future to make a fully fledged data file for all binds and settings.
        private void AppendConfig(List<List<string>>parsedData){
            using (StreamWriter w = File.AppendText("SaveData.txt"))
            {
                w.Write("\r");
                for (int i = 0; i < parsedData.Count; i++){
                    for (int j = 0; j < parsedData[i].Count; j++){
                        if(j + 1 < parsedData[i].Count){
                            w.Write(parsedData[i][j] + " ");
                        }else{
                            w.Write(parsedData[i][j] + "\n");
                        }
                    }
                }
            }
        }

    }
}
