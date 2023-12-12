using Microsoft.AspNetCore.Mvc;
using ProvaSub.Model;
using ProvaSub.Data;

namespace ProvaSub.Controllers
{
    public class ImcController : Controller
    {
        private readonly AppDataContext _context;

        public ImcController(AppDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("imc/listar")]
        public IActionResult Listar()
        {
            List<Imc> imcs = _context.Imc.ToList();
            return Ok(imcs);
        }

        [HttpPost]
        [Route("imc/criar")]
        public IActionResult Criar([FromBody] Imc imc)
        {
            _context.Add(imc);
            _context.SaveChanges();
            return Ok("Aluno Criado!!!");
        }

        [HttpPut]
        [Route("imc/editar/{id}")]
        public IActionResult Editar(int id, [FromBody] Imc imc)
        {
            try
            {
                _context.Update(imc);
                _context.SaveChanges();
                return Ok("IMC editado.");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
