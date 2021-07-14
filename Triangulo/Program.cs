using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um código permitindo ao usuário digitar os 3 lados de um triângulo. 
             * Baseado nos 3 valores digitados, deverá ser exibido se o triangulo é 
             * “inválido”, “equilátero”, “isósceles” ou “escaleno”.
                    Regras:
                            ●	Um triângulo existe se, somente se, um de seus lados for maior que a diferença dos outros dois lados, 
                                    e menor que a soma dos outros dois lados.
                            ●	Um triangulo equilátero possui seus 3 lados com a mesma medida.
                            ●	Um triangulo isósceles possui dois de seus lados com a mesma medida.
                            ●	Um triangulo escaleno possui cada lado com uma medida diferente.
                             */

            int n1=0, n2=0, n3=0;

            
            string msg = "";
            Console.WriteLine("Verifica sim os dados informados representam os lados do triangulo");
            

            Console.WriteLine("Primeiro lado");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo lado");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tercer lado");
            n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 < n2 + n3)     
            {
                if ( n2 < (n1 - n3))
                {
                    if (n3 < (n2 + n1))
                    {
                        msg = "Os valores informados representam os lados de um triangulo";
                    }
                }
            }
            Console.WriteLine(msg);



            if(n1 == n2 && n1 == n3)
            {
                Console.WriteLine("Triangulo Equilatero");
            }
            else if (n1 == n2 || n1 == n3 || n3 == n2)
            {
                Console.WriteLine("triangulo Isoceles");
            }
            else if(n1 != n2 || n2 != n3 || n3 != n1)
            {
                Console.WriteLine("Triangulo Escaleno");
            }

            Console.ReadLine();
            
        }
    }
}
