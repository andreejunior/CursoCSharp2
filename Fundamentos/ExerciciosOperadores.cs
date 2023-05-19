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
            

            Console.WriteLine("Escreva a 1° nota");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a 2° nota");
            double nota2 = double.Parse(Console.ReadLine());

            double nota = (nota1 * 3.5 + nota2 * 7.5) /11 ;

            Console.WriteLine($"Sua nota é {nota.ToString("#.#")}");
        

            Console.WriteLine("Informe seu numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de valor por hora");
            double quantidade = double.Parse(Console.ReadLine());

            double qtd = numero2 * quantidade;

            Console.WriteLine($"Numero de funcionarios: {numero}");

            Console.WriteLine($"Seu salario é {qtd.ToString("#.##")}");
        }
    }
}
