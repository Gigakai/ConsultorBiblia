using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorBiblia.Clases
{
    public class Usuario
    {
        private string email;
        private string password;
        private string nombres;
        private string apellidoPat;
        private string apellidoMat;
        private char genero;
        private DateTime fechaNacimiento;

        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public string NOMBRES { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public char GENERO { get; set; }
        public DateTime FECHANACIMIENTO { get; set; }
        public Usuario(string _email, string _password, string _nombres, string _apellidoPat, string _apellidoMat, char _genero, DateTime _fechaNacimiento)
        {
            email = _email;
            password = _password;
            nombres= _nombres;
            apellidoPat= _apellidoPat;
            ApellidoMat = _apellidoMat;
            GENERO = _genero;
            FECHANACIMIENTO = _fechaNacimiento;
        }
        public void Clear()
        {
            email = string.Empty;
            password = string.Empty;
            apellidoMat= string.Empty;
            apellidoPat= string.Empty;

        }
    }
}
