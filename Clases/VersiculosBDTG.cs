using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorBiblia.Clases
{
    class VersiculosBDTG
    {
        public string testamento { get; set; }
        public string texto { get; set; }
        public string libro { get; set; }
        public VersiculosBDTG(string _texto, string _libro, string _testamento)
        {
            texto = _texto;
            libro = _libro;
            testamento = _testamento;
        }
    }
}
