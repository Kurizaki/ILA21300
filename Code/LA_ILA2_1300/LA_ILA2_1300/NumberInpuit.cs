using System.Security.Cryptography.X509Certificates;

namespace LA_ILA2_1300
{
    class NumberInpuit
    {
        public int guesses = 1;
       
        public int Input()
        {
            startmenu startmenu = new startmenu();
            WlanConnection wlanConnection = new WlanConnection();
            int guessNumber;
            startmenu.center("---------------------------------");
            startmenu.center("Versuchen Sie die Zahl zu erraten");
            while (true)
            {
                try
                {
                    if (startmenu.menuchosen == 2)
                    {
                        wlanConnection.Runmessage();
                        guessNumber = Convert.ToInt32(wlanConnection.messageRead);
                    }
                    else
                    {
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                    }

                    break;
                }
                catch
                {

                }
            }
            return guessNumber;
        }
        public int InputOnlineHost()
        {
            startmenu startmenu = new startmenu();
            WlanConnection wlanConnection = new WlanConnection();
            int guessNumber = 0;
            startmenu.center("---------------------------------");
            startmenu.center("Versuchen Sie die Zahl zu erraten");
            while (true)
            {
                try
                {
                    if (guesses % 2 == 0)
                    {
                        startmenu.center("---------------------------------");
                        startmenu.center("Bitte warten sie bis Ihr Mitspieler eine Zahl gerraten hat.");
                    }
                    else if (guesses % 2 == 1)
                    {
                        wlanConnection.Runmessage();
                        guessNumber = Convert.ToInt32(wlanConnection.messageRead);
                        guesses++;
                    }
                    break;
                }
                catch
                {

                }
            }
            return guessNumber;
        }

        public int InputOnlineJoin()
        {
            startmenu startmenu = new startmenu();
            WlanConnection wlanConnection = new WlanConnection();
            int guessNumber = 0;
            startmenu.center("---------------------------------");
            startmenu.center("Versuchen Sie die Zahl zu erraten");
            while (true)
            {
                try
                {
                    if (guesses % 2 == 1)
                    {
                        startmenu.center("---------------------------------");
                        startmenu.center("Bitte warten sie bis Ihr Mitspieler eine Zahl gerraten hat.");
                    }
                    else if (guesses % 2 == 0)
                    {
                        wlanConnection.Runmessage();
                        guessNumber = Convert.ToInt32(wlanConnection.messageRead);
                        guesses++;
                    }
                    break;
                }
                catch
                {

                }
            }
            return guessNumber;
        }
    }
}