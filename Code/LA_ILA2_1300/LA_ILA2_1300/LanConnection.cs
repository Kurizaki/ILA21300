using System.Net.Sockets;
using System.Net;
using System.Text;

namespace LA_ILA2_1300
{
    class WlanConnection
    {
        startmenu startmenu = new startmenu();
        public string message;
        public int Winning = 0;
        public string SharedRandomNumber { get; set; } = "";
        public List<TcpClient> connectedClients = new List<TcpClient>();
        public void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 12345);
            server.Start();
            Console.WriteLine("Server gestartet...");
            Join();
            using (TcpClient client = server.AcceptTcpClient())
            using (NetworkStream stream = client.GetStream())
            {
                Console.WriteLine("Client connected.");
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(message);
                    Task.Run(() => HandleClient(client));
                    string response = message;
                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                }
            }
            //Quelle Teils: ChatGPT
        }
        private void HandleClient(TcpClient client)
        {
            using (NetworkStream stream = client.GetStream())
            {
                while (true)
                {
                    CompareNumbers compareNumbers = new();
                    SharedRandomNumber = Convert.ToString(compareNumbers.RandomNumber);
                    // Read data from the client
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    SharedRandomNumber = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(message);
                    // Send a response back to the client if needed
                    if (Winning == 1)
                    {
                        string response = "Du hast gewonnen";
                        byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                        stream.Write(responseBytes, 0, responseBytes.Length);
                    }
                }
                   
            }
        }
        string serverIp;
        public string messageRead;
        public void Join()
        {
            Console.Write("Bitte geben sie die Ipv4 Adresse des Netzwerks ein");
            serverIp = Console.ReadLine();
            using (TcpClient client = new TcpClient(serverIp, 12345))
            using (NetworkStream stream = client.GetStream())
            {
                Console.WriteLine("Connected to server.");
                connectedClients.Add(client);

                while (true)
                {
                    byte[] messageBytes = Encoding.UTF8.GetBytes(messageRead);
                    stream.Write(messageBytes, 0, messageBytes.Length);
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                }
            }
            //Quelle Teils: ChatGPT
        }
        
        public void Runmessage()
        {
            while (true)
            {
                try
                {
                    messageRead = Console.ReadLine();
                    break;
                }
                catch
                {
                    startmenu.center("Ungültige Eingabe");
                }
            }
        }
    }
}

