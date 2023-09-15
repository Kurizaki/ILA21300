using System;
using System.Collections.Generic;
using System.IO;

namespace LA_ILA2_1300
{
    public class Highscore
    {
        private List<string> Name = new List<string>();
        private List<int> Score = new List<int>();
        private List<DateTime> Date = new List<DateTime>();
        private List<int> Difficulty = new List<int>();

        public void HighscorePrint()
        {
            Console.Clear();
            startmenu startmenu = new startmenu();
            startmenu.logo();
            startmenu.center("Nickname\t\tScore\tDate\tDifficulty");
            startmenu.center("--------------------------------------");
            for (int i = 0; i < Name.Count; i++)
            {
                PrintTableRow(Name[i], Score[i], Date[i], Difficulty[i]);
            }
            startmenu.center("");
            startmenu.center("Beliebige Taste zum zurückkehren."); ;
            Console.ReadKey();
            Console.Clear();
            startmenu.menu();
        }

        public void PrintTableRow(string nickname, int score, DateTime date, int diff)
        {
            startmenu startmenu = new startmenu();
            startmenu.center($"{nickname}\t\t{score}\t{date}\t{diff}");
        }

        public void AddEntry(DateTime date, int score, string name, int difficulty)
        {
            Date.Add(date);
            Score.Add(score);
            Name.Add(name);
            Difficulty.Add(difficulty);
        }

        private readonly string username = Environment.UserName;

        public void Save()
        {
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\NumberGuesser\savings.txt";
            Directory.CreateDirectory(Path.GetDirectoryName(CredentialsFilePath));
            using (StreamWriter writer = new StreamWriter(CredentialsFilePath))
            {
                for (int i = 0; i < Name.Count; i++)
                {
                    writer.WriteLine($"{Name[i]},{Score[i]},{Date[i]},{Difficulty[i]}");
                }
                 writer.Dispose();
            }
        }
    }
}
