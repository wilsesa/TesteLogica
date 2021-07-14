using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCasa
{
    class Casa
    {
        public string Endereco { get; set; }
        public string Cor { get; set; }
        public int Metragem { get; set; }

        public Comodo comodo { get; set; }


        List<Comodo> Comodos { get; set; }
    }
}
