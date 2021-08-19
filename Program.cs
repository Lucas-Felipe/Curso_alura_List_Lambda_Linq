using System;
using System.Collections.Generic;
using Curso_alura_List_Lambda_Linq.Extensions;
using Proj_Arrays_Genericos;
using Modelos;


namespace Curso_alura_List_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<string> b = new List<string>();

            var c = new ListaObject<object>();

            c.AddVarios(1, 2, 3, 4, 5, 6, 7);

            

            a.Add(1);
            a.Add(3);

            a.AddVarios(7,6,5,4,3,2,1);
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            a.Sort();

            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            b.Add("lucas");
            b.Add("almeida");

            b.AddVarios("bruna","zeta","carol");
            foreach (string item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            b.Sort();

            foreach (string item in b)
            {
                Console.WriteLine(item);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente("lucas",123,"estudanti",456,789),
                new ContaCorrente("zeta",456,"robo",789,987),
                new ContaCorrente("gustavo",789,"teste",987,654),
                new ContaCorrente("carol",741,"advogata",852,963)
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine($"\nNome: {conta.Titular.Nome}, Profission: {conta.Titular.Profission}");
            }
        }
    }
}
