using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetaguardaAPI.Entity;

namespace RetaguardaAPI.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult getAll()
        {

        }

        [HttpGet("{ide}")]
        public IActionResult get(Guid ide) 
        { 

        }

        [HttpPost]
        public IActionResult post(Paciente paciente) 
        { 

        }

        [HttpPut("{ide}")]
        public IActionResult update(Guid ide, Paciente paciente)
        {

        }

        [HttpDelete("ide")]
        public IActionResult delete(Guid ide)
        {

        }
    }
}