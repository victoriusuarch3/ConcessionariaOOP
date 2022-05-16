using Microsoft.AspNetCore.Mvc;
using ConcessionariaOOP.Classes;

namespace ConcessionariaOOP.Web.Controllers

{
    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Veiculos> VeiculoDaClasse {get; set;} = new List<Veiculos>();

        [HttpGet("Veiculo")]
        public IActionResult ValidarAno(Veiculo veiculo)
        {
            try
            {
                veiculo.ValidarAno(veiculo.GetAno);
                VeiculoDaClasse.add(veiculo);
                return(VeiculoDaClasse);
            }
            catch (ErroException ex)
            {
                return BadRequest(ex.mensagem);
            }
        }
    }
}