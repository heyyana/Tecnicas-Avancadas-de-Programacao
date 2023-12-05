using Biblioteca.Data;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Biblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        readonly private ApplicationDBContext _db;
        public EmprestimoController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(EmprestimoModel emprestimos)
        {
            if(ModelState .IsValid)
            {
                _db.Emprestimos.Add(emprestimos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]

        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimoModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if(emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Editar(EmprestimoModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Update(emprestimos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(emprestimo);
        }
        [HttpGet]

        public IActionResult Excluir (int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimoModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if(emprestimo == null)
            {
                return NotFound();
            }
            return View(emprestimo);
        }
    }
}
