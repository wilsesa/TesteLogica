using System;
using System.Collections.Generic;

namespace ListCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Casa> casas = new List<Casa>();
            List<Comodo> comodos = new List<Comodo>();


            casas.Add(new Casa() { Endereco = "Castro Alves 550 ", Cor = "Branco", Metragem = 10});
            //casas.Add(new Casa() { Endereco = "Esmeralda", Cor = "amarelo", Metragem = 250 });
            //casas.Add(new Casa() { Endereco = "Rio Grande", Cor = "Verde", Metragem = 600 });
            
            
            Console.WriteLine();
            foreach (var item in casas)
            {
                Console.WriteLine($"Rua {item.Endereco} - { item.Metragem + "m2"} - 5 comodos{item.comodo}");
            }
        }
    }
}
