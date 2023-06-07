using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string();

            //vamos enfileirar
            fila.Enqueue("Cleiton");
            fila.Enqueue("Carlos");
            fila.Enqueue("Rodrigo");
            fila.Enqueue("Josiscleuda");
            fila.Enqueue("Josivalda");
            //pegando o primeiro elemento da fila
            Console.WriteLine(fila.Peek());
            //contando a fila
            Console.WriteLine(fila.Count);
            //removendo a primeira pessoa da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //verificar quantas pessoas temos na fila
            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
