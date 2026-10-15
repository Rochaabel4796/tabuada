using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_personalizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tabuada Personalizada";
            int numero;
            string validar;
            Console.WriteLine("Diga um numero ");
            validar = Console.ReadLine();
            while (!int.TryParse(validar, out numero) || numero <= 0 || numero > 10)
            {
                if (!int.TryParse(validar, out numero))
                {
                    Console.WriteLine($"{validar} Nao pode ser uma letra");
                }
                else if (numero > 10)
                {
                    Console.WriteLine($"{numero} Numero menor que 10");
                }
                else
                {
                    Console.WriteLine($"{numero} Numero maior que 0");
                }
                validar = Console.ReadLine();

            }
            Console.WriteLine($"Tabuada do {numero} ");
            for (int i=1 ; i<11 ;i++)
            {
                Console.WriteLine($"{numero}*{i}={numero * i} ");
            }


        }
    }
}
