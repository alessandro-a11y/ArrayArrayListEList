using System;

namespace ClasseArray
{
    internal class MediadosAlunos
    {
        static void Main()
        {
            string[] alunos = new string[5];
            double[] notas = new double[5];

            // Coletando os nomes dos alunos
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
                alunos[i] = Console.ReadLine();
            }

            // Coletando as notas dos alunos
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculando a soma das notas
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            // Calculando a média
            double media = soma / notas.Length;

            // Exibindo os resultados
            Console.WriteLine("\nRelatório dos alunos e suas notas:");
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Aluno: {alunos[i]} \t Nota: {notas[i]}");
            }

            // Exibindo a média final
            Console.WriteLine($"\nMédia geral dos alunos: {media}");
        }
    }
}
