using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Construtores
    {

        class Cliente
        {
            //atributos de cliente
            public string nome;
            public string cpf;
            public string sexo;
            public string endereco;
            public int idade;
            public Cliente(string nome, string cpf, string sexo, string endereco, int idade)
            {
                nome = nome;
                cpf = cpf;
                sexo = sexo;
                endereco = endereco;
                idade = idade;
            }
            //criando construtor padrão
            public Cliente ()
            {

            }
        }



        //construtor personalizado
    
      

        public static void Executar()
        {
            var cliente = new Cliente(); // new cliente() é um construtor
            cliente.nome = "Cleber";
            cliente.cpf = "12345678910";
            cliente.sexo = "M";
            cliente.endereco = "Vila Pires";
            cliente.idade = 70;

            var cliente2 = new Cliente("Rogério Ceni", "12345678910", "M", "Ramiro Corleoni", 40);

            var cliente3 = new Cliente()
            {
                nome = "Amanda",
                sexo = "F",
                endereco = "Avenida Portugal",
                idade = 25
            };

            Console.WriteLine($"Olá {cliente.nome} você tem {cliente.idade} anos");
        }
    }
}
