using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, media;

            Console.Clear();

            Console.WriteLine("Digite sua 1° nota: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 2° nota: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 3° nota: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua 4° nota: ");
            d = double.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;

            Console.WriteLine("A média é " + media);

            if (media <= 5)
            {
                Console.WriteLine("Insatisfatório");
            }
            else if (media <= 7.5)
            {
                Console.WriteLine("Regular");
            }
            else if (media <= 9.5)
            {
                Console.WriteLine("Bom");
            }
            else
            {
                Console.WriteLine("Muito Bom");
            }

            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.Read();
        }
    }
}
