using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp1, resp2, resp3, resp4, resp5,
                   resp6, resp7, resp8, resp9, resp10;
            int acertos = 0, erros = 0;
            double prct, crv;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");

            Console.Write("1) O que são dados?");
            Console.WriteLine("\n\nA)Entidades." +
                              "\nB)Relacionamentos." +
                              "\nC)Fatos brutos." +
                              "\nD)Tabelas." +
                              "\nE)Chaves primárias.");
            resp1 = Console.ReadLine();

            if (resp1 == "C" || resp1 == "c")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("2) O que são informações?");
            Console.WriteLine("\nA)Números." +
                              "\nB)Dados processados." +
                              "\nC)Listas." +
                              "\nD)Algoritmos." +
                              "\nE)Pesquisas.");
            resp2 = Console.ReadLine();

            if (resp2 == "B" || resp2 == "b")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("3) Em um banco de dados qual a função da chave primária?");
            Console.WriteLine("\nA)Fornecer um identificador único para cada dado inserido na tabela." +
                              "\nB)Relacionar entidades." +
                              "\nC)Converter uma string no formato data." +
                              "\nD)Retornar a média aritmética." +
                              "\nE)Agrupar dados em comum.");
            resp3 = Console.ReadLine();

            if (resp3 == "A" || resp3 == "a")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("4) Qual o significado da sigla SQL?");
            Console.WriteLine("\nA)Structured Query Line." +
                              "\nB)System Query Location." +
                              "\nC)Structured Query Logic." +
                              "\nD)Structured Query Language." +
                              "\nE)System Query Logic.");
            resp4 = Console.ReadLine();

            if (resp4 == "D" || resp4 == "d")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("5) Qual dos SGBD's abaixo não é um banco de dados relacional?");
            Console.WriteLine("\nA)Oracle." +
                              "\nB)MongoDB." +
                              "\nC)MS-SQL Server." +
                              "\nD)SQLite." +
                              "\nE)MySQL.");
            resp5 = Console.ReadLine();

            if (resp5 == "B" || resp5 == "b")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("6) Qual a sigla em inglês para se referir ao administrador de um banco de dados?");
            Console.WriteLine("\nA)ABD." +
                              "\nB)ADB." +
                              "\nC)DAB." +
                              "\nD)BAD." +
                              "\nE)DBA.");
            resp6 = Console.ReadLine();

            if (resp6 == "E" || resp6 == "e")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("7) Em bancos relacionais qual a função de uma chave estrangeira?");
            Console.WriteLine("\nA)Fornecer um identificador único para dado inserido na tabela" +
                             "\nB)Converter uma string no formato data." +
                             "\nC)Relacionar entidades." +                             
                             "\nD)Retornar a média aritmética." +
                             "\nE)Agrupar dados em comum.");
            resp7 = Console.ReadLine();

            if (resp7 == "C" || resp7 == "c")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("8) Os bancos relacionais são composto por quais modelos?");
            Console.WriteLine("\nA)Sequencial, Estruturado e Orientado a Objetos." +
                              "\nB)Estruturado, Cascata e Orientado a Objetos." +
                              "\nC)Fila, Pilha e Árvore." +
                              "\nD) Conceitual, Lógico e Físico." +
                              "\nE)Fila, Pilha e Grafo.");
            resp8 = Console.ReadLine();

            if (resp8 == "D" || resp8 == "d")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("9) Na modelagem de um banco relacional qual figura geométrica reprsenta as entidades?");
            Console.WriteLine("\nA)Retângulo." +
                              "\nB)Circulo." +
                              "\nC)Triângulo." +
                              "\nD)Trapésio." +
                              "\nE)Losango.");
            resp9 = Console.ReadLine();

            if (resp9 == "A" || resp9 == "a")
                acertos++;
            else
                erros++;

            Console.Clear();
            Console.WriteLine("QUIZ - Conceitos de Banco de Dados\n");
            Console.WriteLine("10) Na modelagem de um banco relacional qual figura geométrica reprsenta os relacionamentos?");
            Console.WriteLine("\nA)Retângulo." +
                              "\nB)Circulo." +
                              "\nC)Triângulo." +
                              "\nD)Trapésio." +
                              "\nE)Losango.");
            resp10 = Console.ReadLine();

            if (resp10 == "E" || resp10 == "e")
                acertos++;
            else
                erros++;

            crv = acertos;

            prct = (crv / 10) * 100;

            Console.Clear();
            Console.WriteLine("Quantidade de acerto(s): {0}", acertos);
            Console.WriteLine("Quantidade de erro(s): {0}", erros);
            Console.WriteLine("Porcentagem: " + prct + "%");
            Console.WriteLine("Obrigado Por Responder!!!");
            Console.ReadKey();
        }
    }
}
