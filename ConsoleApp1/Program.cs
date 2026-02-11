using System;
using System.Collections;
namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>()
            {
                "Maria", "Pedro","Ana"
            };

            string[] array1 =
            {
                "Diná", "Carlos"
            };

            lista.AddRange(array1);
            Imprimir(lista);
            lista.InsertRange(1, array1);
            Imprimir(lista);
            Console.WriteLine($"{lista.Count} items");
        }
        static void Imprimir(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.Write($"{item} | ");
                
            }
            Console.WriteLine();
        }

    }
}
//lista.Add("B");
//lista.Add("A");
//lista.Add("D");
//lista.Add("C");          
//lista.Add("F");
//lista.Add("E");
//Imprimir(lista);

//lista.Sort();
//Imprimir(lista);