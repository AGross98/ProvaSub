using Microsoft.AspNetCore.Mvc;
using ProvaSub.Model;
using ProvaSub.Data;

namespace ProvaSub.Controllers{
    public class AlunoController : Controller{
        private readonly AppDataContext _context;

        public AlunoController(AppDataContext context) {
            _context = context;
        }

        [HttpGet]
        [Route("aluno/listar")]
        public IActionResult Listar() {
            List<Aluno> alunos = _context.Aluno.ToList();
            return Ok(alunos);
        }

        [HttpPost]
        [Route("aluno/criar")]
        public IActionResult Criar([FromBody] Aluno aluno){
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok("Aluno Criado!!!");
        }
    }
}
