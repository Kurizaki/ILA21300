namespace LA_ILA2_1300
{
    class CompareNumbers
    {
        NumberInpuit numberInpuit = new();
        WlanConnection wlanConnection = new WlanConnection();
        Highscore highscore= new Highscore();
        ContinuePlaying continuePlaying = new();
        startmenu startmenu = new startmenu();

        int tries = 0;
        int _randomNumber;
        int score = 10000;
        public string nickname;
        public int diff;
        public int RandomNumber
        {
            get { return _randomNumber; }
            set { }
        }
        public void Compare(int randomNumber, int guessNumber)
        {
            bool loop = true;
            Console.Clear();
            while (loop == true) 
            {
                tries++;
                startmenu.logo();
                if (randomNumber < guessNumber)
                {
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Deine Zahl ist zu gross.");
                    guessNumber = numberInpuit.Input();
                    score = score - 500;
                }
                else if (randomNumber > guessNumber)
                {
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Deine Zahl ist zu klein.");
                    guessNumber = numberInpuit.Input();
                    score = score - 500;
                }
                else
                {
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Du hast die Zahl richtig geraten! Du hast den Score von " + score + " Punkten!");
                    startmenu.center("Du hast " + tries + " Versuche gebraucht!");
                    highscore.AddEntry(DateTime.Today, score, nickname, diff);
                    highscore.Save();
                    break;
                }
            }
        }
        public void difficulty()
        {
            int difficulty_input;

            try
            {
                Console.Clear();
                startmenu.logo();
                startmenu.center("Herrzlich willkommen zum Numberguesser " + nickname);
                startmenu.center("");
                startmenu.center("Suche dir eine Schwierigkeit aus");
                startmenu.center("");
                startmenu.center("1 (1-100)");
                startmenu.center("2 (1-500)");
                startmenu.center("3 (1-1000)");

                if (startmenu.menuchosen == 2)
                {
                    wlanConnection.Runmessage();
                    difficulty_input = Convert.ToInt32(wlanConnection.messageRead);
                }
                else
                {
                    difficulty_input = Convert.ToInt32(Console.ReadLine());
                }

                switch (difficulty_input)
                {
                    case 1:
                        diff = 1;
                        Generation(101);
                        break;

                    case 2:
                        diff = 2;
                        Generation(501);
                        break;

                    case 3:
                        diff = 3;
                        Generation(1001);
                        break;

                    default:
                        startmenu.center("Ungültige Eingabe");
                        break;
                }
            }
            catch
            {
                startmenu.center("Ungültige Eingabe");
            }
        }

        public void Generation(int difficulty)
        {
            Random rnd = new();
            int randomNumber = rnd.Next(1, difficulty);
            RandomNumber = randomNumber;
            Compare(randomNumber, numberInpuit.Input());
            NewRound();
        }

        public void CompareOnline(int randomNumber, int guessNumber)
        {
            int win = 0;
            bool loop = true;
            Console.Clear();
            while (loop == true)
            {
                startmenu.logo();
                if (randomNumber < guessNumber)
                {
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Deine Zahl ist zu gross.");
                    guessNumber = numberInpuit.Input();
                    win = 0;
                }
                else if (randomNumber > guessNumber)
                {
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Deine Zahl ist zu klein.");
                    guessNumber = numberInpuit.Input();
                    win = 0;
                }
                else
                {
                    win = 1;
                    Console.Clear();
                    startmenu.logo();
                    startmenu.center("Du hast die Zahl richtig geraten!");
                    onlineWinner();

                    break;
                }
                if (wlanConnection.Winning == 1)
                {
                    Console.Clear();
                    startmenu.logo();
                    onlineWinner();
                    break;
                }
            }
        }
        public void onlineWinner()
        {
            if (numberInpuit.guesses % 2 == 0)
            {
                startmenu.center("Spieler 2 (Join) Hat gewonnen!");
            }
            else if (numberInpuit.guesses % 2 == 1)
            {
                startmenu.center("Spieler 1 (Host) Hat gewonnen!");
            }
        }
        public void create_nickname()
        {
            Console.Clear();
            startmenu.logo();
            startmenu.center("Wie möchtest du genannt werden, Fremder?");

            if (startmenu.menuchosen == 2)
            {
                wlanConnection.Runmessage();
                nickname = wlanConnection.messageRead;
            }
            else
            {
                nickname = Console.ReadLine();
                difficulty();
            }
        }

        private readonly string username = Environment.UserName;
        public void existingFile()
        {
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\NumberGuesser\savings.txt";

            if (!File.Exists(CredentialsFilePath) || string.IsNullOrEmpty(File.ReadLines(CredentialsFilePath).FirstOrDefault()))
            {
                filecreation();
            }
            else
            {
                readFile();
            }
        }

        private void filecreation()
        {
            if (!File.Exists(@$"C:\Users\{username}\AppData\Roaming\NumberGuesser\savings.txt"))
            {
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string savingFolder = Path.Combine(appDataFolder, "NumberGuesser");
                _ = Directory.CreateDirectory(savingFolder);
                string savingFile = Path.Combine(savingFolder, "savings.txt");
                using StreamWriter writer = File.CreateText(savingFile);
                writer.WriteLine(",");
            }
        }

        private void readFile()
        {
            string CredentialsFilePath = @$"C:\Users\{username}\AppData\Roaming\NumberGuesser\savings.txt";
            string[] lines = File.ReadAllLines(CredentialsFilePath);

            List<string> Name = new List<string>();
            List<int> Score = new List<int>();
            List<DateTime> Date = new List<DateTime>();
            List<int> Difficulty = new List<int>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                if (fields.Length >= 4)
                {
                    Name.Add(fields[0]);

                    if (int.TryParse(fields[1], out int score))
                    {
                        Score.Add(score);
                    }

                    if (DateTime.TryParse(fields[2], out DateTime date))
                    {
                        Date.Add(date);
                    }

                    if (int.TryParse(fields[3], out int difficulty))
                    {
                        Difficulty.Add(difficulty);
                    }
                }
                highscore.AddEntry(Date[i], Score[i], Name[i], Difficulty[i]);
            }
        }
        public void highscoreprint()
        {
            highscore.HighscorePrint();
        }
        public void NewRound()
        {
            WlanConnection wlanConnection = new WlanConnection();
            startmenu startmenu = new startmenu();
            bool isNewRound = true;
            startmenu.center("Wollen Sie erneut spielen[j|n]");
            while (true)
            {
                try
                {
                    string loop;
                    if (startmenu.menuchosen == 2)
                    {
                        wlanConnection.Runmessage();
                        loop = wlanConnection.messageRead;
                    }
                    else
                    {
                        loop = Console.ReadLine();
                    }


                    if (loop == "j")
                    {
                        difficulty();
                        break;
                    }
                    if (loop == "n")
                    {
                        startmenu.menu();
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                catch
                {
                    startmenu.center("Falsche Eingabe!");
                }
            }
        }
    }
}