using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace OrcamentoTeste.Controllers
{
    
    public class ProdutoOrcamentoController : Controller
    {
         List<ProdutoOrcamento> selecionados = new List<ProdutoOrcamento>();
         static List<Produto> produtos = new List<Produto>();
         ProdutoOrcamento pd = new ProdutoOrcamento();
        private readonly ProdutoDAO _produtoDAO;
        private readonly OrcamentoDAO _orcamentoDAO;
        private readonly ProdutoOrcamentoDAO _produtoOrcamentoDAO;
        
        
        public ProdutoOrcamentoController(ProdutoDAO produtoDAO, OrcamentoDAO orcamentoDAO, ProdutoOrcamentoDAO produtoOrcamento)
        {
            _orcamentoDAO = orcamentoDAO;
            _produtoDAO = produtoDAO;
            _produtoOrcamentoDAO = produtoOrcamento;
        }
        
            public IActionResult Cadastrar(int id)
        {
             produtos = _produtoDAO.Listar();
            Orcamento o = _orcamentoDAO.BuscarPorId(id);
            if(_produtoOrcamentoDAO.ListarporOrcamento(o) != null)
            {
                selecionados = _produtoOrcamentoDAO.ListarporOrcamento(o);
                ViewBag.selecionados = selecionados;
            }
            else
            {
                ViewBag.selecionados = null;
            }
            ViewBag.Key = id;
            ViewBag.produtos = produtos;
            
            return View();
        }

    [HttpPost]
        public IActionResult Cadastrar(int id, int quantidade, int key)
        {
            Orcamento o = _orcamentoDAO.BuscarPorId(key);
            pd.Produto = _produtoDAO.BuscarPorId(id);
            pd.Quantidade = quantidade;
            pd.Orcamento = o;
            _produtoOrcamentoDAO.Cadastrar(pd);
            return Cadastrar(key); ; 

        }

       

        public IActionResult Listar(int id)
        {
            Orcamento or = new Orcamento();
            or = _orcamentoDAO.BuscarPorId(id);
           List<ProdutoOrcamento> listOrcamento =_produtoOrcamentoDAO.ListarporOrcamento(or);
            listOrcamento.Count();
            if(listOrcamento == null || listOrcamento.Count == 0)
            {
                _orcamentoDAO.Remover(id);
                return RedirectToRoute(new { controller = "Orcamento", action = "Index"});

            }
            ViewBag.nome = or.NomeCliente;
            return View(listOrcamento);
        }


        public IActionResult Alterar(int id)
        {
            Orcamento o = _orcamentoDAO.BuscarPorId(id);
            return View
                (_produtoOrcamentoDAO.ListarporOrcamento(o));
        }


        [HttpPost]
        public IActionResult Alterar(ProdutoOrcamento al)
        {
            _produtoOrcamentoDAO.AlterarProdutoOrçamento(al);
            return RedirectToAction("Home");

        }

        [HttpPost]
        public IActionResult Remover(int id, int key )
        {
            _produtoOrcamentoDAO.Remover(id);
            
            return RedirectToRoute(new {  action = "Listar", id = key});

        }

    }
}