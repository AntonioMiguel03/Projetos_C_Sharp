using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Clear();
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine()); 
            if (num % 2 == 0)
                Console.WriteLine(num + " é um número par.");         
            else            
                Console.WriteLine(num + " é um número ímpar.");            

            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.Read();
        }
    }
}
