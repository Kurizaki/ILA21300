namespace LA_ILA2_1300
{
    class Credits
    {
        startmenu startmenu = new startmenu();
        public void credit()
        {
            Console.Clear();
            startmenu.center("   _____ _        __                   _                 _         ");
            startmenu.center("  / ____| |      / _|                 | |               | |        ");
            startmenu.center(" | (___ | |_ ___| |_ __ _ _ __        | | ___  ___ _ __ | | _____  ");
            startmenu.center("  \\___ \\| __/ _ \\  _/ _` | '_ \\   _   | |/ _ \\/ __| '_ \\| |/ / _ \\ ");
            startmenu.center("  ____) | ||  __/ || (_| | | | | | |__| |  __/\\__ \\ | | |   < (_) |");
            startmenu.center(" |_____/ \\__\\___|_| \\__,_|_| |_|  \\____/ \\___||___/_| |_|_|\\_\\___/ ");
            startmenu.center("");
            startmenu.center("   ___   ");
            startmenu.center("  ( _ )  ");
            startmenu.center("  / _ \\/\\");
            startmenu.center(" | (_>  <");
            startmenu.center("  \\___/\\/");
            startmenu.center("");
            startmenu.center("  _  __                        _  __          _               _ _       ");
            startmenu.center(" | |/ /                       | |/ /         | |             (_|_)      ");
            startmenu.center(" | ' / ___  __ _ _ __  _   _  | ' / ___   ___| | _____      ___ _ _ __  ");
            startmenu.center(" |  < / _ \\/ _` | '_ \\| | | | |  < / _ \\ / _ \\ |/ _ \\ \\ /\\ / / | | '_ \\ ");
            startmenu.center(" | . \\  __/ (_| | | | | |_| | | . \\ (_) |  __/ |  __/\\ V  V /| | | | | |");
            startmenu.center(" |_|\\_\\___|\\__,_|_| |_|\\__,_| |_|\\_\\___/ \\___|_|\\___| \\_/\\_/ |_| |_| |_|");
            startmenu.center("                                                              _/ |      ");
            startmenu.center("                                                             |__/       ");
            startmenu.center("");
            startmenu.center("Beliebige Taste zum zurückkehren.");
            Console.ReadKey();
            startmenu.menu();
        }
    }
}