using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Rota com mesmo nome da 'Views' não precisa informar, pois já conhece, se alterar, precisa informar como por exemplo alterar Privacy para provacys
        /// deve passar por parâmetro o mesmo nome da rota, senão vai enxegar como outro parâmetro
        /// enquanto o tipo, pode ser string, pode não importa, pois terá liberdade passar int, guid ou o mesmo a string
        /// caso altere o parametro diferente da rota, por exemplo string "categorias", no navegador colocará /Home/Index/10?categorias=Teste, se acrescentear outro parametro e no navegador colocará: /Home/Index/10?categorias=Teste&ca2=Teste2
        /// </summary>
        /// <returns></returns>
        /// 
        [Route("")]//vai para home senão passar nada
        [Route("gestao-pagina-inicial")]
        [Route("gestao-pagina-inicial/{id?}")]
        [Route("gestao-pagina-inicial/{id=int}/{categoria=guid}")]
        public IActionResult Index(int id, Guid categoria)
        {

            /*

            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };


            return RedirectToAction("Privacy", filme);
            */
            
            //pode retornar arquivo, mensagem, todo resultado possível
            return View();
        }

        [Route("privacidade")] //se chamar, funciona tbm
        [Route("politica-de-privacidade")] //prevalece a última padrão
        public IActionResult Privacy(Filme filme)
        {

            if(ModelState.IsValid)
            {

            }

            //como extrair listas de erros
            foreach (var erros in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(erros.ErrorMessage);
            }

            //retornar um json
            //return Json("{'Nome' : 'Deivide Regis'}");

            /*
            //retorna um arquivo
            var fileBytes = System.IO.File.ReadAllBytes(@"G:\PROJETO\Exemplos API\MinhaDemoMvc\Arquivo.txt");
            var fileName = "Ola.txt"; //pode especificar o nome qualquer - só para especificar nome do arquivo para download

            //download : System.Net.Mime.MediaTypeNames.Application.Octet
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            */

            //retornar uma mensagem
            return Content("Ola desenvolvedor back-End");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
