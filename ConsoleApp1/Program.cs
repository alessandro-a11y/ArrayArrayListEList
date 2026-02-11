using System;
using System.Collections;
namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            
            lista.Add("B");
            lista.Add("A");
            lista.Add("D");
            lista.Add("C");          
            lista.Add("F");
            lista.Add("E");
            Imprimir(lista);

            lista.Sort();
            Imprimir(lista);
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