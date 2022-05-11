using System;
using System.Linq;

namespace sistema_de_medias_de_uma_turma_de_10_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NomesDosAlunos = new string[10];
            decimal[] NotasDosAlunos = new decimal[10];
            decimal menor = 0, maior = 0, Posicao_Menor = 0, Posicao_maior = 0;

            for (int i = 0; i < NomesDosAlunos.Length; i++)
            {
                Console.WriteLine("insira um nome e sua nota");
                NomesDosAlunos[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite a nota dele(a):");
                NotasDosAlunos[i] = Convert.ToDecimal(Console.ReadLine());

                if (i == 0)
                {
                    menor = NotasDosAlunos[0];
                    maior = NotasDosAlunos[0];
                }

                if (NotasDosAlunos[i] < menor)
                {

                    menor = NotasDosAlunos[i];
                    Posicao_Menor = i;

                }
                else if (NotasDosAlunos[i] > maior)
                {
                    maior = NotasDosAlunos[i];
                    Posicao_maior = i;
                }
                

            }

            Console.WriteLine($"A maior nota é: {maior}");
            Console.WriteLine($"A menor nota é: {menor}");
            double numSum = (double)NotasDosAlunos.Sum();
            Console.WriteLine($"A média de todos os alunos é: {numSum / 10}");




        }
    }
}
