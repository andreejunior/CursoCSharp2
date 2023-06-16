using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Poo
{
    class Atividade
    {

        public class Cliente
        {
            public string Nome;
            public int Tipo;

           
        }

        public class Fisico : Cliente
        {
            public string Cpf;
        }

        public class Juridico : Cliente
        {
            public string Cnpj;
        }

        public static void Executar()
        {
            Cliente pessoa1 = new Cliente();
            Juridico pessoaJuridica = new Juridico();
            Fisico pessoaFisica = new Fisico();

            Console.WriteLine("Informe 1 para cliente fisico e 2 para cliente juridico");
            pessoa1.Tipo = int.Parse(Console.ReadLine());

            if (pessoa1.Tipo == 1)
            {
                Console.WriteLine("Digite seu cpf:");
                pessoaFisica.Cpf = Console.ReadLine();
                Console.WriteLine($"o cpf digitado foi:{pessoaFisica.Cpf}");
            } else if (pessoa1.Tipo == 2) 
            {
                Console.WriteLine("Digite seu cnpj:");
                pessoaJuridica.Cnpj = Console.ReadLine();
                Console.WriteLine($"o cnpj digitado foi: {pessoaJuridica.Cnpj}");
            }
            else
            {
                Console.WriteLine("Código invalido");
            }


        }
    }
}
