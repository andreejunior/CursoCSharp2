using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturasDeRepeticao
    {
        public static void Executar ()
        {
            /* Console.WriteLine("Digite um número: ");
             int.TryParse(Console.ReadLine(), out int valor);

             Console.WriteLine("Digite a quantidade de números: ");
             int.TryParse(Console.ReadLine(), out int saltos); */

            /* int cont = 1;
            int qtd = 0;
            int numero = 0;

            while(cont <= 10)
            {
                Console.WriteLine("Digite um número");
                int.TryParse(Console.ReadLine(), out qtd);

                numero = numero + qtd;

                cont++;
            }

            Console.WriteLine($"A soma total foi de: {numero}");
            */

            /*Console.WriteLine("Digite um número:");
            int.TryParse(Console.ReadLine(), out int numero);

            int cont = 1;
            while (cont <= numero)
            {

                Console.WriteLine(cont);
                cont++;
                */

            Console.WriteLine("Digite um número:");
            int.TryParse(Console.ReadLine(), out int numero);


            int cont = 1;

            while (cont <= 10)
            {

                Console.WriteLine($"{numero} X {cont} = {numero * cont}");
                cont++;


                //2 x 1 = 2
                // 2 x 2  = 6
                //2 X 3
                //2 X 4
                // 2 X 5

            }
           }

            
        }
    }

