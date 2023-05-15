using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosIfElse
    {
        public static void Executar()
        {
            /*Console.WriteLine("Digite seu ano de nascimento:");
            int idade = int.Parse(Console.ReadLine());

            idade = 2023 - idade;
          

            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Você tem {idade} anos, seu voto é obrigatório");
            }
            else {
                Console.WriteLine($"Você tem {idade} anos, você não é obrigado a votar");
            }
           

            var senha = "1234";

            Console.WriteLine("Digite sua senha");
            var confirmar = Console.ReadLine();

            if (confirmar == senha){
                Console.WriteLine("Senha correta.");

            }
            else
            {
                Console.WriteLine("Senha Incorreta.");
            }
             

            Console.WriteLine("Informe a 1° nota");
            double  n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 2° nota");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 3° nota");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if (media >= 7.0)
            {
                Console.WriteLine("Você está aprovado");
            }
            else if(media >= 5.0 && media < 7.0){
                Console.WriteLine("Você está de recuperação");
            }else {
                Console.WriteLine("Você está reprovado");            
            }
            */

            Console.WriteLine("Informe seu peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura:");
            double alt = double.Parse(Console.ReadLine());

            double imc = peso / (alt * alt);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            } else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Você está com o peso normal");
            } else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Você está acima do peso");
            } else if (imc >= 24.9 && imc < 29.9)
            {
                Console.WriteLine("Sua obesidade é grau 1");
            } else if (imc >= 29.9 && imc < 34.9)
            {
                Console.WriteLine("Sua obesidade é grau 2");
            } else if (imc >= 34.9 && imc < 39.9)
            { }else
                Console.WriteLine("Sua obesidade é grau 3");
            {
            
           

            }
        }
                
    }
}
