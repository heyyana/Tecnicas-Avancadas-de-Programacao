using Microsoft.AspNetCore.Mvc;
using Locadora.Models;
using Locadora.Data;


namespace Locadora.Controllers
{
    public class AluguelFilmeController : Controller
    {
        readonly private ApplicationDBContext _db;
        public AluguelFilmeController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AluguelFilmeModel> aluguel = _db.Aluguel;
            return View(aluguel);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(AluguelFilmeModel aluguel)
        {
            if (ModelState.IsValid)
            {
                _db.Aluguel.Add(aluguel);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AluguelFilmeModel aluguel = _db.Aluguel.FirstOrDefault(x => x.Id == id);

            if (aluguel == null)
            {
                return NotFound();
            }

            return View(aluguel);
        }

        [HttpPost]
        public IActionResult Editar(AluguelFilmeModel aluguel)
        {
            if (ModelState.IsValid)
            {
                _db.Aluguel.Update(aluguel);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(aluguel);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AluguelFilmeModel aluguel = _db.Aluguel.FirstOrDefault(x => x.Id == id);

            if (aluguel == null)
            {
                return NotFound();
            }
            return View(aluguel);
        }
        [HttpPost]
        public IActionResult Excluir(AluguelFilmeModel aluguel)
        {
            if(aluguel == null)
            {
                return NotFound();
            }
            _db.Aluguel.Remove(aluguel);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
