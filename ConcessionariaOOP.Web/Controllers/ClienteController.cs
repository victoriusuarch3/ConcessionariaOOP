using Microsoft.AspNetCore.Mvc;
using ConcessionariaOOP.Classes;

namespace ConcessionariaOOP.Web.Controllers

{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<Cliente> ClienteDaClasse {get; set;} = new List<Cliente>();

        [HttpPost("Cliente")]
        public IActionResult Carro(Cliente cliente)
        {
            ClientDaClasse.Add(cliente);
            return Ok(ClienteDaClasse);
        }
    }
}