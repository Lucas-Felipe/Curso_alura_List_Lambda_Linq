using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_alura_List_Lambda_Linq.Extensions
{
    public static class ListExtensions
    {
        public static void AddVarios<T>(this List<T> listadeinteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listadeinteiros.Add(item);
            }
        }
    }
}
