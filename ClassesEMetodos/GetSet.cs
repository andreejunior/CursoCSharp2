using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {

        class Cliente
        {
            /*o modificador PRIVATE vai garantir
              que somente a class Cliente vai ter acesso
              ao nome*/
            private string nome;

            /*Entretanto haverá momentos em que precisaremos
              tirar esse valor ou abstrair alguma informação
              então usamos o GET e SET.
             GET PEGA O VALOR e o SET ENVIAR O VALOR*/

            /*GET e o SET precisam ser IGUAIS ao nosso atributo
              da classe Cliente porém com a primeira letra maiuscula*/
            private string Nome
            {
                //aqui vamos especificar nossas ações
                get
                {
                    //para pegar valor de NOME, eu vou usar o return
                    return nome;
                }
                set
                {
                    /*set vai servir para que eu envie um valor
                      então esse value é o valor que o usuário
                      vai me informar na outra classe*/
                    nome = value;
                }
            }

        }
        public static void Executar ()
        {
                /*vamos instanciar um objeto da nossa classe Cliente*/
                Cliente cliente1 = new Cliente();

                //usando o SET para enviar uma informação
              //  cliente1.Nome = "Cleiton";

            //Console.WriteLine(cliente1.Nome);
        }
    }
}
