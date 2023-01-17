using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;
        private StreamReader sReader;

        public OurClient() // конструктор клиента
        {
            client = new TcpClient("127.0.0.1", 5555); // адрес и порт клиента
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8); // поток отправки сооб
            sReader = new StreamReader(client.GetStream(), Encoding.UTF8); // поток чтения сообщ

            HandleCommunication();
        }

        void HandleCommunication() // работаем с соединением
        {
            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sWriter.WriteLine(message); // отправляем сообщение в поток
                sWriter.Flush(); // отправить немедленно.

                string answerServer = sReader.ReadLine();
                Console.WriteLine($"Сервер ответил -> {answerServer}"); // считываем ответ сервера
            }
        }


    }
}