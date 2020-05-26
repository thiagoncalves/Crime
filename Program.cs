using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crime
{
    class Program
    {
        static void Main(string[] args)
        {
            int somaSim = 0;
            string resposta;

            Console.WriteLine("Responda 'S' ou 'N' para as seguintes perguntas: ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Você telefonou para a vitima?");
            resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
                somaSim++;
            Console.Clear();

            Console.WriteLine("Você esteve no local do crime?");
            resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
                somaSim++;
            Console.Clear();

            Console.WriteLine("Você mora no local do crime?");
            resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
                somaSim++;
            Console.Clear();

            Console.WriteLine("Você devia para a vítima?");
            resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
                somaSim++;
            Console.Clear();

            Console.WriteLine("Você já trabalho com a vitima?");
            resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
                somaSim++;
            Console.Clear();

            RetornoQtdeSim(somaSim);

        }
        public static void RetornoQtdeSim(int qtde)
        {
            switch (qtde)
            {
                case 1:
                    Console.WriteLine("O entrevistado é Inocente");
                    break;

                case 2:
                    Console.WriteLine("O entrevistado é Suspeito");
                    break;

                case 3:
                    Console.WriteLine("O entrevistado é Cúmplice");
                    break;

                case 4:
                    Console.WriteLine("O entrevistado é Cúmplice");
                    break;

                case 5:
                    Console.WriteLine("O entrevistado é Assassino");
                    break;
            }

            Console.ReadLine();
        }
    }
}
