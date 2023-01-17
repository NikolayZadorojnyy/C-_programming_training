// сначала запускаем сервер а только потом клиент.

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш сервер");
            OurServer server = new OurServer(); // создали сервер
        }
    }
}
