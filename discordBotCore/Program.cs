using System;
using System.Linq;

namespace discordBotCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Any() && args.First() == "--version")
            {
                Console.WriteLine("0.0.1");
                return;
            }
            Console.WriteLine("Hello World!");
        }
    }
}