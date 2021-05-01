using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace OrcamentoTeste.Controllers
{
    public class SubCategoriaController : Controller
    {
        private readonly SubCategoriaDAO _subCategoriaDAO;
        public SubCategoriaController(SubCategoriaDAO subCategoriaDAO)
        {
            _subCategoriaDAO = subCategoriaDAO;
        }

        public IActionResult Cadastrar()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(SubCategoria sub)
        {


            if (ModelState.IsValid)
            {
                _subCategoriaDAO.Cadastrar(sub);
                return RedirectToRoute(new { controller = "Produto", action = "Cadastrar",});
                
            }
            return View(sub);
        }

    }
}