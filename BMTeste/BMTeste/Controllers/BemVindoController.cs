using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMTeste.Controllers
{
    public class BemVindoController : Controller
    {
        // GET: /<controller>/
        //método Index abaixo retorna um objeto View()
        public IActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Eeste  é um método que adiciona /BemVindo/ á URL";
        //}

        //public string Inicio()
        //{
        //    return "este  é um método que adiciona /BemVindo/Inicio á URL";
        //}

        //public string Inicio(string nome, int numVezes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Ola {nome}, ID = {ID}");
        //}
        public IActionResult Inicio(string nome, int NumVezes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Ola {nome}, ID = {ID}");
            ViewData["Mensagem"] = "Olá " + nome;
            ViewData["NumVezes"] = NumVezes;
            return View();
        }


    }
}
