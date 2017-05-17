using Microsoft.AspNetCore.Mvc;
using StartupDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupDemo.ViewComponents
{
    public class CarrinhoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var carrinho = new Carrinho()
            {
                TotalItems = 10,
                ValorTotal = 550
            };

            return View(carrinho);
        }
    }    
}
