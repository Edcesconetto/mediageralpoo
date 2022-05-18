using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDIA_GERAL_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Media Geral do Aluno ###";

            Console.WriteLine("Quantos alunos: ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Alunos[] alunos = new Alunos[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + "Nome..: ");
                string nome = Console.ReadLine();
                
                Console.Write("Aluno #" + (i + 1) + "Provas: ");
                int prova = int.Parse(Console.ReadLine());

                alunos[i] = new Alunos(nome, prova);
                Console.WriteLine("Insiras as notas do aluno " + nome);

                alunos[i].InserirNotas();

            }
            Console.Clear();

            double mediaGeral = 0;
            foreach (Alunos aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media);
                Console.WriteLine();
                mediaGeral += aluno.Media;
                if (aluno.Media < 50)
                {
                    Console.WriteLine("Reprovado");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
            }
         
            double resultadoFinal = mediaGeral / alunos.Length;
            Console.WriteLine("Média geral dos alunos: " + resultadoFinal);

           
            Console.ReadKey();
        }
    }
}
