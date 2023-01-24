using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffieHellman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // gemeinsame zahlen
            int p = 7823;
            int g = 51;

            // Alice
            int a = 43;
            int A = g ^ a % p;

            // Bob
            int b = 98;
            int B = g ^ b % p;

            // gemeinsamer Schlüssel
            if ((double)(B ^ a) == (double)(A ^ b))
            {
                Console.WriteLine("Beide Schlüssel gleich!");
            } else
            {
                Console.WriteLine("Die Schlüssel sind nicht gleich!");
            }

            Console.ReadKey();
        }
    }
}
