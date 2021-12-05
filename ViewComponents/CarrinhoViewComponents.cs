using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.ViewComponents
{
    /// <summary>
    /// herdando 'ViewComponent'
    /// </summary>
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponents : ViewComponent
    {
        //prop => gerar propriedade automatica
        public int ItensCarrinho { get; set; }

        //ctor => gerar construtor automática
        public CarrinhoViewComponents()
        {
            //retorna resultado do banco de dados, exemplo abaixo 3
            ItensCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return View(ItensCarrinho);
        }
    }
}
