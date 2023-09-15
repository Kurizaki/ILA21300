namespace LA_ILA2_1300
{
    class Host
    {
        WlanConnection wlanConnection = new WlanConnection();
        NumberInpuit numberInpuit = new();
        CompareNumbers compareNumbers = new();
        startmenu startmenu = new();
        public void HostServer()
        {
            wlanConnection.StartServer();
            wlanConnection.Join();
            startmenu.center("Bitte warten Sie bis Ihr Mitspieler dem Spiel beigetreten ist");

            if (wlanConnection.connectedClients.Count == 2)
            {
                compareNumbers.CompareOnline(compareNumbers.RandomNumber, numberInpuit.InputOnlineHost());
            }
        }
    }
}