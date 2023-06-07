using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    class Heranca
    {
        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            // a variavel velocidadeMaxima será transmitida por herança
            // por isso que estamos usando o protected
            int velocidadeAtual;



            //criando o construtor de carro
            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }



            //criando método para acelerar o carro
            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = velocidadeAtual + delta;
                if (novaVelocidade < 0)
                {
                    velocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    velocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    velocidadeAtual = novaVelocidade;
                }



                return velocidadeAtual;
            }
            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }



            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        //herança de Carro
        public class Uno : Carro
        {
            /*o número 200 que está entre base ()
             * significa a velocidadeMaxima que foi herdado de carro
             * usamos base para não precisa fazer o construtor novamente
             */
            public Uno() : base(200)
            {



            }
        }

        public class Porsche : Carro
        {
         
            public Porsche() : base(280)
            {



            }
        }

        public static void Executar()
        {
            Console.WriteLine("Uno...");
            //instanciar carro1 em Uno
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Porsche...");
            Porsche carro2 = new Porsche();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
        }
    }
}
