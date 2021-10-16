using System;

namespace Apka
{
    class Program
    {
        static void checkPrime(int podana)
        {
            int counter = 0;
            for(int i = 1; i<podana; i++)
            {
                if (podana % i == 0)
                {
                    Console.WriteLine()
                }
            }
            if (counter > 2)
            {
                Console.WriteLine("Nie jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine("Jest liczbą pierwszą");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int podana = Convert.ToInt32(Console.ReadLine());
            checkPrime(podana);

        }
    }
}
