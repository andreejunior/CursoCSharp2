using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio2
    {
        public class Nota
        {

            private double n1;
            private double n2;
            private double n3;



            public double Media
            {
                get
                {
                    return (n1 + n2 + n3) / 3;
                }



                set
                {
                    n1 = value;
                    n2 = value;
                    n3 = value;
                }



            }




            public Nota(double n1, double n2, double n3)
            {
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;
            }

        }




        public static void Executar()
        {
            var media = new Nota(3.3, 7.2, 5.5);
            Console.WriteLine($"Média: {media.Media.ToString("#.#")}");


        }

    }

    }
