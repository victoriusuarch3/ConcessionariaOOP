using Microsoft.AspNetCore.Mvc;
using ConcessionariaOOP.Classes;

namespace ConcessionariaOOP.Web.Controllers

{
    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> CarroDaClasse {get; set;} = new List<Carro>();

        [HttpPost("Carro")]
        public IActionResult Carro(Carro carro)
        {
            CarroDaClasse.Add(carro);
            return Ok(CarroDaClasse);
        }
    }
}