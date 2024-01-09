using ContaCerta.Data;
using ContaCerta.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContaCerta.Controllers
{
    public class DespesaController : Controller
    {
        readonly private ApplicationDbContext _db;
        public DespesaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<DespesasModel> despesas = _db.Despesas;
            return View(despesas);
        }

        public IActionResult Cadastrar() //Esse metodo retorna a view cadastrar
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(DespesasModel despesas)
        {
            if(ModelState.IsValid)
            {
                _db.Despesas.Add(despesas);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
