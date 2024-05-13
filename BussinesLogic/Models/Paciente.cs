using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Models
{
    public class Paciente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int CI { get; set; }
        public Paciente(string nombre, string apellido, int ci)
        {
            this.nombre =nombre;
            this.apellido =apellido;
            this.CI = ci;
        }
    }
}
