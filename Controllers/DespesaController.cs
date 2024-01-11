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

        [HttpGet]
        public IActionResult Cadastrar() //Esse metodo retorna a view cadastrar
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(DespesasModel despesas) //Esse metodo cadastra 
        {
            if(ModelState.IsValid)
            {
                despesas.ValorTotalAPagar = despesas.ValorDaParcela * despesas.QuantidadeTotalDeParcelas;
                despesas.QuantiadeDeParcelasFaltantes = despesas.QuantidadeTotalDeParcelas - despesas.QuantidadeParcelasPagas;
                despesas.ValorTotalPago = despesas.ValorDaParcela * despesas.QuantidadeParcelasPagas;

                _db.Despesas.Add(despesas);
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

            DespesasModel despesa = _db.Despesas.FirstOrDefault(x => x.Id == id);

            if(despesa == null)
            {
                return NotFound();
            }
            return View(despesa);
        }

        [HttpPost]
        public IActionResult Editar(DespesasModel despesas)
        {
            despesas.ValorTotalAPagar = despesas.ValorDaParcela * despesas.QuantidadeTotalDeParcelas;
            despesas.QuantiadeDeParcelasFaltantes = despesas.QuantidadeTotalDeParcelas - despesas.QuantidadeParcelasPagas;
            despesas.ValorTotalPago = despesas.ValorDaParcela * despesas.QuantidadeParcelasPagas;

            if (ModelState.IsValid)
            {
                _db.Despesas.Update(despesas);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(despesas);
        }

    }
}
