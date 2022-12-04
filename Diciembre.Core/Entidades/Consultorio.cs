using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diciembre.Core.Entidades
{
    public class Consultorio
    {
        public int Id { get; set; }
        public string NumeroExterno { get; set; }
        public Doctor Doctor { get; set; }

    }
}
