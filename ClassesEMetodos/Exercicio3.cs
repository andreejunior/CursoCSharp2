using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio3
    {
        public class Animais
        {
            string nome;
            string tipo;



            public string Nome
            {
                get
                {
                    return nome;
                }



                set
                {
                    nome = value;
                }
            }



            public string Tipo
            {
                get
                {
                    return tipo;
                }



                set
                {
                    tipo = value;
                }
            }



            public Animais(string nome, string tipo)
            {
               Nome = nome;
                Tipo = tipo;
            }



        }

        public static void Executar()
        {
            Console.WriteLine("Qual o nome do animal?");
            string ani = Console.ReadLine();



            Console.WriteLine("Qual seu tipo?(por gentileza digitar em letras minúsculas)");
            string tip = Console.ReadLine();




            var animal = new Animais(ani, tip);



            switch (tip)
            {
                case "cachorro":
                    Console.WriteLine($"Nome: {animal.Nome}, é um(a) {animal.Tipo} ");
                    Console.WriteLine("Características dos cachorros:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-fucinho grande");
                    Console.WriteLine("-orelhas");
                    Console.WriteLine("-rabo");
                    break;



                case "gato":
                    Console.WriteLine($"Nome: {animal.Nome}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos gatos:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-grandes reflexos");
                    Console.WriteLine("-orelhas");
                    Console.WriteLine("-rabo");
                    break;



                case "ave":
                    Console.WriteLine($"Nome: {animal.Nome}, é um {animal.Tipo} ");
                    Console.WriteLine("Características das aves:");
                    Console.WriteLine("-contém penas");
                    Console.WriteLine("-bípede");
                    Console.WriteLine("-contém bico");
                    Console.WriteLine("-asas");
                    break;



                case "Cachorro":
                    Console.WriteLine($"Nome: {animal.Nome}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos cachorros:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-fucinho grande");
                    Console.WriteLine("-orelhas");
                    Console.WriteLine("-rabo");

                    break;



                case "Gato":
                    Console.WriteLine($"Nome: {animal.Nome}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos gatos:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-grandes reflexos");
                    Console.WriteLine("-orelhas");
                    Console.WriteLine("-rabo");
                    break;



                case "Ave":
                    Console.WriteLine($"Nome: {animal.Nome}, é um {animal.Tipo} ");
                    Console.WriteLine("Características das aves:");
                    Console.WriteLine("-contém penas");
                    Console.WriteLine("-bípede");
                    Console.WriteLine("-contém bico");
                    Console.WriteLine("-asas");
                    break;




            }




        }
    }
}
        
    

