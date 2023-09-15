using System.CodeDom.Compiler;

namespace LA_ILA2_1300
{
    class Join
    {
        startmenu startmenu = new();
        CompareNumbers compareNumbers = new();
        NumberInpuit numberInpuit = new();
        WlanConnection wlanConnection = new();

        public void JoinGame()
        {
            wlanConnection.Join();
            startmenu.center("Bitte warten sie bis ihr Host das Spiel eingerichtet hat.");

            if (wlanConnection.connectedClients.Count == 2)
            {
                bool isGenerated = false;

                if (isGenerated == true)
                {
                    startmenu.center("Die Zahl wurde Generiert.");
                }
                while (isGenerated == true)
                {

                }
                //get generated number
                compareNumbers.CompareOnline(compareNumbers.RandomNumber, numberInpuit.InputOnlineJoin());
            }
        }
    }
}