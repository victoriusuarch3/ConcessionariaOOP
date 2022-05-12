using Microsoft.AspNetCore.Mvc;
namespace ConcessionariaOOP.Web.Controllers
{
    [ApiController]
    [Route("ControllerConcessionaria")]
    public class ConcessionariaApi : ControllerBase
    {
        public static List<Carro> CarroDaClasse {get; set;} = new List<Carro>();

        [HttpGet("Carro")]
        public IActionResult Carro()
        {
            CarroDaClasse.Add(Carro);
            return Ok(CarroDaClasse);
        }
    }
}