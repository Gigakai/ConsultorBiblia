using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorBiblia.Clases
{
    internal class VersiculoCDTG
    {
        public string texto { get; set; }
        public string libro { get; set;}
        public string numCap { get; set;}
        public string idVers { get; set;}
        public VersiculoCDTG(string _texto, string _libro, string _numCap, string _idVers) { 
            texto= _texto;
            libro= _libro;
            numCap= _numCap;
            idVers= _idVers;
        }
    }
}
