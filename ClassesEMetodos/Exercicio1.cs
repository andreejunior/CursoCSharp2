using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio1
    {

        class Pessoa
        {
            private string nome;

            private double altura;

            private int idade;

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public double Altura
            {
                get { return altura; }
                set { altura = value; }
            }
            public int Idade
            {
                get { return idade; }
                set { idade = value; }
            }

            public void imprimirDados()
            {
                Console.WriteLine($"Olá! {nome} essa é sua altura {altura} e sua idade {idade}");
            }


            public int calculoIdade()
            {
                return  2023 - idade;
            }
        }   

      

        public static void Executar ()
        {


            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "André";
            pessoa1.Altura = 1.88;
            pessoa1.Idade = 19;
            pessoa1.imprimirDados();
            pessoa1.calculoIdade();

            int idade = pessoa1.Idade;

            Console.WriteLine(idade);
        }
    }
}
