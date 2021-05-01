using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace OrcamentoTeste.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly ProdutoDAO _produtoDAO;
        private readonly SubCategoriaDAO _subCategoriaDAO;
        private readonly ProdutoOrcamentoDAO _produtoOrcamentoDAO;

        public ProdutoController(ProdutoDAO produtosDAO,SubCategoriaDAO subCategoriaDAO, ProdutoOrcamentoDAO produtoOrcamento)
        {
            _produtoDAO  = produtosDAO;
            _subCategoriaDAO = subCategoriaDAO;
            _produtoOrcamentoDAO= produtoOrcamento;

        }
        public IActionResult Index()
        {

            return View(_produtoDAO.Listar());
        }
        
        public IActionResult Cadastrar()
        {
            ViewBag.Sub = new SelectList(_subCategoriaDAO.Listar(),
             "idSub", "nome");

            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Produto p, int drpSub, float valor)
        {
            ViewBag.Sub= new SelectList(_subCategoriaDAO.Listar(),
            "idSub", "nome");
            p.SubCategoria = _subCategoriaDAO.BuscarPorId(drpSub);
            p.Valor = Convert.ToDouble(p.Valor);   
            _produtoDAO.Cadastrar(p);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id, int drpSub)
        {
            Produto p = _produtoDAO.BuscarPorId(id);
            ViewBag.Sub = new SelectList(_subCategoriaDAO.Listar(),
           "idSub", "nome");
            p.SubCategoria = _subCategoriaDAO.BuscarPorId(drpSub);



            return View(p);
        }
        [HttpPost]
        public IActionResult AlterarProduto(Produto p, int drpSub)
        {
            
            ViewBag.Sub = new SelectList(_subCategoriaDAO.Listar(),
           "idSub", "nome");
            p.SubCategoria = _subCategoriaDAO.BuscarPorId(drpSub);


            _produtoDAO.Alterar(p);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Remover(int id)
        {
            Produto p = _produtoDAO.BuscarPorId(id);
           List<ProdutoOrcamento> lt = _produtoOrcamentoDAO.ListarporProduto(p);
            if(lt.Count != 0) { 
            for(int i =0; i != lt.Count; i++)
            {
                _produtoOrcamentoDAO.Remover(lt[i].IdProdutoOrcamento);
            }
            }
            _produtoDAO.Remover(id);
            return RedirectToAction("Index");
        }
    }
}