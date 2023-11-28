using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetaguardaAPI.Entity;

namespace RetaguardaAPI.Controllers
{
    [Route("api/paciente")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly dbContext _dbContext;

        public PacienteController(dbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            var result = _dbContext.Paciente.Where(i => i.Status.Equals(0)).ToList();
            return Ok(result);
        }

        [HttpGet("{ide}")]
        public IActionResult get(Guid ide) 
        { 
            var result = _dbContext.Paciente.FirstOrDefault(i => i.Ide.Equals(ide));
            return result is null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public IActionResult post(Paciente paciente) 
        { 
            _dbContext.Paciente.Add(paciente);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(get), new { ide = paciente.Ide}, paciente);
        }

        [HttpPut("{ide}")]
        public IActionResult update(Guid ide, Paciente paciente)
        {
            var result = _dbContext.Paciente.First(i => i.Ide.Equals(ide));
            if (result is null)
                return NotFound();

            result.Name = paciente.Name;
            result.Status = paciente.Status;
            result.Description = paciente.Description;

            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{ide}")]
        public IActionResult delete(Guid ide)
        {
            var result = _dbContext.Paciente.First(i => i.Ide.Equals(ide));
            if (result is null)
                return NotFound();

            result.Status = -1;
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}