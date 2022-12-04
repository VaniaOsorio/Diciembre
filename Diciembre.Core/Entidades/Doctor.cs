using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diciembre.Core.Entidades
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Rfc { get; set; }

        public string CedulaProfesional { get; set; }

        public string Email { get; set; }

        public string Especialidad { get; set; }
    }
}
