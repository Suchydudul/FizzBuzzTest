using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                string z = "";
                if (x % 3 == 0) z += "Fizz";
                if (x % 5 == 0) z += "Buzz";
                if (z.Length == 0) z += x;
                Console.WriteLine(z);
            }
        }
    }
}