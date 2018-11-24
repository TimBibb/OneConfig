using System;
using System.IO;
using System.Collections.Generic;

namespace OneConfig
{
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

        public void SetMainGames(List<int> games){
            for (int i = 0; i < games.Count; i++){
                mainGames.Add(games[i]);
            }
            AppendConfig(testData);
        }
        public List<int> GetMainGames(){
            return mainGames;
        }

        //On submit of main games
        private void GetConfig(List<int> games){
            for (int i = 1; i < games.Count; i++){
                switch (games[i-1])
                {
                    case 1:
                        //Insert parseBO4
                        break;
                    case 2:
                        //Insert parseBF1
                        break;
                    case 3:
                        //Insert parseBFV
                        break;
                    case 4:
                        //Insert parseOverwatch
                        break;
                    case 5:
                        //Insert parseCSGO...
                        break;
                    default:
                        break;
                }
            }
        }

        private void AppendConfig(List<List<string>>parsedData){
            using (StreamWriter w = File.AppendText("SaveData.txt"))
            {
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
