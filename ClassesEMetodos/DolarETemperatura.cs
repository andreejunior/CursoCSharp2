using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DolarETemperatura
    {

        /* public double Dolar(double real, double dolar)
         {
             return real / dolar;
         }


         public static void Executar()
         {
             double dolar = 4.95;

             var dolar1 = new DolarETemperatura();

             Console.WriteLine("Digite a quantidade de reais");
             double real = double.Parse(Console.ReadLine());

             Console.WriteLine(dolar1.Dolar(real, dolar));

         }*/
        class convertor { 
        public double temperatura(double celsius)
        {
            return (celsius * 9 / 5) + 32;

        }
    }
        public static void Executar()
        {
            var temp = new convertor();

            Console.WriteLine("informe a temperatura");
            double celsius = double.Parse(Console.ReadLine());

            Console.WriteLine(temp.temperatura(celsius));
        }
        
    }
}
