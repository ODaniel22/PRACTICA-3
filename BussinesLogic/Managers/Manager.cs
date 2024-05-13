using BussinesLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Managers
{
    public class Manager
    {
        public string CodigoPaciente(Paciente paciente)
        {
            string codigo;
            codigo = $"{paciente.nombre[0]}{paciente.apellido[0]}-{paciente.CI}";
            return codigo;
        }
    }
}
