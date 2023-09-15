namespace LA_ILA2_1300
{
    class ContinuePlaying
    {
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
                        isNewRound = true;
                        break;
                    }
                    if (loop == "n")
                    {
                        isNewRound = false;
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