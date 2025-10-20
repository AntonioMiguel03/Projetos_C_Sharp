using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string vFrase, vLetra;
            int vQtd, cont_A, cont_E, cont_I, cont_O, cont_U, conso;

            Console.Clear();
            Console.Write("Digite uma frase: ");
            vFrase = Console.ReadLine();
            vQtd = vFrase.Length;
            Console.WriteLine("\nEssa frase tem {0} caracteres", vQtd);

            cont_A = 0;
            cont_E = 0;
            cont_I = 0;
            cont_O = 0;
            cont_U = 0;
            conso = 0;


            for (int i = 0; i < vQtd; i++) 
            {
                vLetra = vFrase.Substring(i, 1);

                switch (vLetra.ToUpper())
                {

                    case "A":
                        {
                            cont_A++;
                            break;
                        }
                    case "À":
                        {
                            cont_A++;
                            break;
                        }
                    case "Á":
                        {
                            cont_A++;
                            break;
                        }
                    case "Ã":
                        {
                            cont_A++;
                            break;
                        }
                    case "E":
                        {
                            cont_E++;
                            break;
                        }
                    case "É":
                        {
                            cont_E++;
                            break;
                        }
                    case "I":
                        {
                            cont_I++;
                            break;
                        }
                    case "Í":
                        {
                            cont_I++;
                            break;
                        }
                    case "O":
                        {
                            cont_O++;
                            break;
                        }
                    case "Ó":
                        {
                            cont_O++;
                            break;
                        }
                    case "Õ":
                        {
                            cont_O++;
                            break;
                        }
                    case "U":
                        {
                            cont_U++;
                            break;

                        }
                    case "Ú":
                        {
                            cont_U++;
                            break;

                        }
                    case " ":
                        {
                            break;
                        }
                    case ".":
                        {
                            continue;
                        }
                    default:
                        {
                            conso++;
                            break;
                        }
                }
            }
            Console.WriteLine("\n>>> A frase tem as seguintes vogais \n{0} LETRAS [A] \n{1} LETRAS [E] \n{2} LETRAS [I] \n{3} LETRAS [O] \n{4} LETRAS [U] \n\nE possui {5} CONSOANTES", cont_A, cont_E, cont_I, cont_O, cont_U, conso);
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.Read();
        }
    }
}
