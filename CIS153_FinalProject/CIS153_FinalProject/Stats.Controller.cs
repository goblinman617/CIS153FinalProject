using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CIS153_FinalProject {
    internal class StatsController {

        //Just add a stats controller to the form and input the correct number for whoever won.
        //It will write to the text file
        public void writeTextFile(int winner) { // 0 = Player win, 1 = Bot win, 2 = Draw

            // this is kind of a gross way to do it, but it was very easy and works great
            List<string> file = File.ReadAllLines("../../MatchHistory.txt").ToList();
            int num;
            switch (winner) {
                case 0:
                    num = Int32.Parse(file[winner]);
                    num++;
                    file[winner] = num.ToString();
                    File.WriteAllLines("../../MatchHistory.txt", file.ToArray());
                    break;
                case 1:
                    num = Int32.Parse(file[winner]);
                    num++;
                    file[winner] = num.ToString();
                    File.WriteAllLines("../../MatchHistory.txt", file.ToArray());
                    break;

                case 2:
                    num = Int32.Parse(file[winner]);
                    num++;
                    file[winner] = num.ToString();
                    File.WriteAllLines("../../MatchHistory.txt", file.ToArray());
                    break;
                default:
                    System.Console.WriteLine("Bad input into writeFile()");
                    break;

            }
        }
        //You shouldn't need this elsewhere in the program
        public void readTextFile(MatchHistory info) {
            // Simple read the text file and set values
            // It sets all values even the ones we dont store
            StreamReader file = new StreamReader("../../MatchHistory.txt");
            string s = file.ReadLine();
            info.setPlayerWins(Int32.Parse(s));

            s = file.ReadLine();
            info.setAIWins(Int32.Parse(s));

            s = file.ReadLine();
            info.setDraws(Int32.Parse(s));

            file.Close();

            info.setTotalGames((info.getAIWins() + info.getPlayerWins() + info.getDraws()));
            if (info.getTotalGames() != 0) {
                info.setPWinPercent(info.getPlayerWins() / info.getTotalGames() * 100);
                info.setAIWinPercent(info.getAIWins() / info.getTotalGames() * 100);
                info.setDrawPercent(info.getDraws() / info.getTotalGames() * 100);
            } else {
                Console.WriteLine(info.getTotalGames());
                info.setPWinPercent(0);
                info.setAIWinPercent(0);
                info.setDrawPercent(0);
            }
        }
    }
}
