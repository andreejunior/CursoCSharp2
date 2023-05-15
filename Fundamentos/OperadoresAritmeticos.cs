using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos {
        public static void Executar()
        {
            //Console.WriteLine("Informe o primeiro número");
            //int n1 = int.Parse (Console.ReadLine());

            //Console.WriteLine("Informe o segundo número");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{n1} + {n2} = {n1 + n2}");

            Console.WriteLine("Informe a base");
            double bas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura");
            double alt = double.Parse(Console.ReadLine());

            Console.WriteLine($" a área do triângulo é {(bas * alt) / 2}. Ele tem {bas} de base e {alt} de altura");
        }
    }
  
}





