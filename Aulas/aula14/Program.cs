using System;

namespace aula14
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            int media = 0;

            string result = "";

            Console.Write("Insira a nota1 do Aluno: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Insira a nota2 do Aluno: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Insira a nota3 do Aluno: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("Insira a nota4 do Aluno: ");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media < 3)
            {
                result = "Reprovado";
            }
            else
            {
                if (media >= 4 && media <= 6)
                {
                    result = "Recuperação";
                }
                else if (media >= 6 && media <= 7)
                {
                    result = "Aprovado";
                    if (media >= 7 && media <= 8)
                    {
                        result = "Aprovado com Distinção";
                    }
                    else
                    {
                        result = "Aprovado com Louvor";
                    }

                }
            }
            Console.WriteLine("Resultado: {0} com nota {1}", result, media);
        }


    }

}

