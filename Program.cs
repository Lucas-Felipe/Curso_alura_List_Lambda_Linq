using System;
using System.Collections.Generic;
using Curso_alura_List_Lambda_Linq.Extensions;


namespace Curso_alura_List_Lambda_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<string> b = new List<string>();


            a.Add(1);
            a.Add(3);

            a.AddVarios(1,3,6,5,4,7);

            a.Remove(1);
            a.Remove(6);
            a.Remove(3);
            a.Remove(1);
            Console.WriteLine(a.Count);

            b.AddVarios("asjdnjdas","fsdfsfds","doido");
            Console.WriteLine(b.Count);
            
        }
    }
}
