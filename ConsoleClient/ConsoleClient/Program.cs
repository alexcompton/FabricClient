using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client.Client(0);
            var rand = new Random();

            while(true)
            {
                var counter = (long)rand.Next(500);
                client.SetToService(counter);
                Console.WriteLine("\nSet Service Counter to: {0}", counter);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(client.GetFromService().Result);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
