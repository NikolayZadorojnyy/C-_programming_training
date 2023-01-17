using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer() // запуск сервера
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);
            server.Start();

            LoopClients();  
        }

        void LoopClients() // слушаем клиента и создаем поток под кажлого клиента
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient(); // создание объекта клиент на сервере

                Thread thread = new Thread(() => HandleClient(client)); // создание потока под клиента
                thread.Start();
            }
        }

        void HandleClient(TcpClient client) // обрабатываем поток от клиента
        {
            // поток для считавания от клиента
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);
            // поток для ответа от сервера
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            while (true) // обрабатываем сообщения
            {
                string message = sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {message}"); // принимаем сообщение клиента

                Console.WriteLine("Дайте сообщение клиенту: ");
                string answer = Console.ReadLine();
                sWriter.WriteLine(answer); // отправляем ответ клиенту
                sWriter.Flush(); // ответить немедленно
            }
        }
    }
}