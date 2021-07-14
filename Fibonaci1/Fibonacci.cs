using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci1
{
    class Fibonacci
    {
        public void Executar(int n)
        {
            int a = 1, b = 2, c = 1;


            for (int i = 1; i < n; i++)
            {
                if (i < n - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }

                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
