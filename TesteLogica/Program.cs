using Fibonacci;
using System;

namespace TesteLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.	Desenvolva uma aplicação para exibir na tela, 
             * com o uso de recursividade, 
             * os 30 primeiros resultados da “Sequência de Fibonacci”. 
             * ●	Sequencia básica de Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...*/

            RecursividadeFibonacci fi = new RecursividadeFibonacci();
            fi.Executar(30);
        }
    }
}
