using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace OrcamentoTeste.Controllers
{
    public class OrcamentoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        private readonly OrcamentoDAO _orcamentoDAO;
        private readonly ProdutoOrcamentoDAO _produtoOrcamentoDAO;

        public OrcamentoController(ProdutoDAO produtoDAO, OrcamentoDAO orcamentoDAO, ProdutoOrcamentoDAO produtoOrcamento)
        {
            _orcamentoDAO = orcamentoDAO;
            _produtoDAO = produtoDAO;
            _produtoOrcamentoDAO = produtoOrcamento;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Orcamento o)
        {
            o.Data = DateTime.Now;
                _orcamentoDAO.Cadastrar(o);
                ViewBag.Id = o.IdOrcamento;
            return RedirectToRoute(new { controller = "ProdutoOrcamento", action = "Cadastrar",  id =o.IdOrcamento });

        }

        public IActionResult Listar(int id)
        {
            return RedirectToRoute(new { controller = "ProdutoOrcamento", action = "Listar", id = id });
        }

        public IActionResult Index()
        {
            return View(_orcamentoDAO.Listar());
        }

       
    }
}