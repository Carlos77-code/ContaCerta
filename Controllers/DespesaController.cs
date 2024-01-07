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
    }
}
