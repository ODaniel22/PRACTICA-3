using BussinesLogic.Managers;
using BussinesLogic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practica_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private Manager manager;
        public PacienteController(Manager manager )
        { 
            this.manager = manager;
        }
        [HttpPost]
        public string Post([FromBody] Paciente paciente)
        { 
            return manager.CodigoPaciente(paciente); 
        }
    }
}
