using System;
using System.Collections.Generic;

namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Casas> myCasas = new List<Casas>();
            List<Comodo> comodos = new List<Comodo>();


            myCasas.Add(new Casas { Endereco = "Rua XV de Novembro ", Cor= " Branco", Metragem= - 200});
            myCasas.Add(new Casas { Endereco = "Av Santo Amaro ", Cor = " Verde", Metragem = - 100 });
            myCasas.Add(new Casas { Endereco = "Rua 13 de maio ", Cor = " Amarelo", Metragem = - 500 });
            myCasas.Add(new Casas { Endereco = "Rua Ibirapuera ", Cor = " Branco", Metragem = - 350 });

            foreach (var casas in myCasas)
            {
                Console.WriteLine(casas.Endereco + casas.Metragem + " m2 - " + casas.Comodos + "2 Comodos" );
            }
        }

        class Casas
        {
            public string Endereco { get; set; }
            public string Cor { get; set; }
            public int Metragem { get; set; }

            public Comodo Comodos { get; set; }
        }

        class Comodo
        {
            public string Nome { get; set; }
            public int Janelas { get; set; }
            public int Portas { get; set; }
        }
    }
}
