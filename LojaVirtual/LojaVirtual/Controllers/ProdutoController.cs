﻿using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {

            Produto produto = GetProduto();

            return View(produto);
            //return new ContentResult() { Content = "Produto -> Visualizar", ContentType="text/html" };
        }

        private Produto GetProduto()
        {
            return new Produto(){
                Id = 1,
                Nome = "Xbox",
                Descricao = "Legal",
                Valor = 2000.00M
            };
        } 
    }
}
