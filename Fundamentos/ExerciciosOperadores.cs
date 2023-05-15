using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosOperadores
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva a 1° nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a 2° nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a 3° nota");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A 1° nota é {n1}");
            Console.WriteLine($"A média do aluno é {n1}!");
        }
    }
}
