using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageInput.MyServiceReference;

namespace MessageInput
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv meddelande (max 50 tecken): ");

            var service = new MyServiceClient();
            string message = Console.ReadLine();

            Console.WriteLine(service.AddMessage(message));
            Console.WriteLine("Tryck på valfri tangent för att avsluta.");
            Console.ReadKey();
        }
    }
}
