using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }
   
        [HttpGet("/bsm")]
        public string Bsm()
        {
            return "Responsabilidade Pessoal\nMentalidade de Crescimento\nOrientação ao Futuro\nPersistência\nComunicação\n" + "Orientação ao Detalhe\nProatividade\nTrabalho em Equipe";
        }
        [HttpGet("/objetivos")]
        public string Objetivos()
        {
            return "Fixar o que é uma API e como realizar uma.\nEntender os conceito de MVC e aplica-los.\nEntender sobre requisição e respostas.";
        }
    }
}
