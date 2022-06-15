using CadastroProfessores1._0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CadastroProfessores1._0.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto _contexto;
        public ProfessorController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> index()
        {
            return View(await _contexto.Professores.ToListAsync());
        }
        [HttpGet]

        public IActionResult CriarProfessor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarProfessor(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(professor);
                await _contexto.SaveChangesAsync();
                return View(nameof(index));
            }
            else return View(professor);
        }

        [HttpGet]
        public IActionResult AtualizarProfessor(int? id)
        {

            if (id != null)
            {
                Professor professor = _contexto.Professores.Find(id);
                return View(professor);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarProfessor(int id, Professor professor)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(professor);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(index));
                }
                else return View(professor);
            }
           return NotFound();
        }
        [HttpGet]
        public IActionResult ExcluirProfessor(int? id)
        {
            if (id != null)
            {
                Professor professor = _contexto.Professores.Find(id);
                return View(professor);
            }
            else return NotFound();

        }
        public async Task<IActionResult> ExcluirProfessor(int id, Professor professor)
        {
            if (id != null)
            {
                _contexto.Remove(professor);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(index));

            }
            else return NotFound();

        }
    }
}
