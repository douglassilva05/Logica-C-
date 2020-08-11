using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindromo
{
    class Palindromo
    {
        static void Main(string[] args)
        {
            String original, reverse = "";

            Console.WriteLine("Entre com a string : ");
            original = Console.ReadLine();

            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
                reverse = reverse + original.ElementAt(i);

            if (original.Equals(reverse))
                Console.WriteLine("A string inserida é um palíndromo.");
            else
                Console.WriteLine("A string inserida não é um palíndromo.");

            Console.ReadLine();
        }
    }
}

