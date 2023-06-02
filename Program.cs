using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados -= Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercicios Operadores - Fundamentos",ExerciciosOperadores.Executar },
                {"Exercicios If Else - Fundamentos",ExerciciosIfElse.Executar },
                {"Estrutura Switch - Fundamentos",EstruturaSwitch.Executar },
               // {"Estrutura While E For - Fundamentos",EstruturaWhileEfor.Executar },
                {"Estruturas de Repetição - Fundamentos",EstruturasDeRepeticao.Executar },
                {"Estrutura For Each - Fundamentos",EstruturaForEach.Executar },
                {"Dolar e Temperatura - Fundamentos",DolarETemperatura.Executar },
              

                //Classes e Metodos
                {"Membros - Classes e Métodos",Membros.Executar },
                {"Construtores - Fundamentos",Construtores.Executar },
                {"Metodos Com Retorno - Fundamentos",MetodosComRetorno.Executar },
                {"Metodos Estaticos - Fundamentos",MetodosEstaticos.Executar },
                {"Params - Classes e Métodos",Params.Executar },
                {"Get Set - Classes e Métodos",GetSet.Executar },
                {"Get Set Segundo Exemplo - Classes e Métodos",GetSetSegundoExemplo.Executar },
                {"Exercicio 1 - Classes e Métodos",Exercicio1.Executar },
                {"Exercicio 2 - Classes e Métodos",Exercicio2.Executar },
                {"Exercicio 3 - Classes e Métodos",Exercicio3.Executar },

                //Coleções
                {"Arrays - Coleções",Arrays.Executar },
                {"Coleções Queue - Coleções",ColecoesQueue.Executar }
            });

            central.SelecionarEExecutar();
        }
    }
}