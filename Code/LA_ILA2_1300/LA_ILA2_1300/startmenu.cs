using static System.Net.Mime.MediaTypeNames;

namespace LA_ILA2_1300
{
    class startmenu
    {
        public bool isStartanimation = true;
        public void startanimation()
        {
            
            System.Threading.Thread.Sleep(150);
            center(" _______                  __                    _______                                     ");
            System.Threading.Thread.Sleep(150);
            center("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
            System.Threading.Thread.Sleep(150);
            center("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
            System.Threading.Thread.Sleep(150);
            center("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
            System.Threading.Thread.Sleep(500);
            center("                                                                                            ");
            System.Threading.Thread.Sleep(1000);
            center("Beliebige Taste zum Starten");
            Console.ReadKey();
            ShowSimplePercentage();
            center("Beliebige Taste zum Starten");
            Console.ReadKey();
            Console.Clear();
            menu();

            isStartanimation = false;
        }
        public void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                logo();
                center($"Loading: {i}%");
                Thread.Sleep(25);
                Console.Clear();
            }
            logo();
            center("Fertig!");
        }
        public int menuchosen;
        public void center(string textToEnter)
        {
            if (multiplayerDecision == 1)
            {
                WlanConnection wlanConnection = new WlanConnection();
                wlanConnection.message = String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter);
            }
            else if(isStartanimation == true)
            {
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            }
            //Quelle: https://stackoverflow.com/questions/21917203/how-do-i-center-text-in-a-console-application
        }

        public void logo()
        {
            center(" _______                  __                    _______                                     ");
            center("|    |  |.--.--.--------.|  |--.-----.----.    |     __|.--.--.-----.-----.-----.-----.----.");
            center("|       ||  |  |        ||  _  |  -__|   _|    |    |  ||  |  |  -__|__ --|__ --|  -__|   _|");
            center("|__|____||_____|__|__|__||_____|_____|__|      |_______||_____|_____|_____|_____|_____|__|  ");
            center("                                                                                            ");
            center("                                                                                            ");
        }

        public void menu()
        {
            Console.Clear();
            logo();
            center("");
            center("1) Einzelspieler");
            center("");
            center("2) Mehrspieler");
            center("");
            center("3) Leaderboard");
            center("");
            center("4) Credits");
            center("");
            center("5) Beenden");
            bool check = true;
            while(check)
            {
                CompareNumbers compareNumbers = new();
                compareNumbers.existingFile();
                try
                {
                    int menuchose = Convert.ToInt32(Console.ReadLine());
                    check = false;
                    menuchosen = menuchose;
                    switch (menuchose)
                    {
                        case 1:
                            compareNumbers.create_nickname();
                            break;
                        case 2:
                            Multiplayer();
                            break;
                        case 3:
                            compareNumbers.highscoreprint();
                            break;
                        case 4:
                            Credits credits = new Credits();
                            credits.credit();
                            break;
                        case 5:
                            Console.Clear();
                            logo();
                            center("");
                            center("Vielen Dank fürs Spielen :)");
                            System.Threading.Thread.Sleep(2000);
                            Environment.Exit(0);
                            break;
                        default: break;
                    }
                }
                catch
                {
                    center("Falsche Eingabe!");
                    check = true;
                }
            }
        }

        public int multiplayerDecision;
        public void Multiplayer()
        {
            Host host = new();
            Join join = new();
            Console.Clear();
            logo();
            center("");
            center("Mehrspieler (Max. 2 Spieler):");
            center("");
            center("1) Host");
            center("");
            center("2) Join");
            center("");
            center("3) Zurück");
            multiplayerDecision = Convert.ToInt32(Console.ReadLine());
            switch (multiplayerDecision)
            {
                case 1:
                    host.HostServer();
                    break;
                case 2:
                    join.JoinGame();
                    break;
                case 3:
                    menu();
                    break;
                default : break;
            }
        }
    }
}