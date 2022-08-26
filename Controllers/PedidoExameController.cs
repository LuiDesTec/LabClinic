using LabClinic.Entitie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LabClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoExameController : ControllerBase

    {
        private List<Exame> exames = new List<Exame>()
        {
                new Exame()
                {
                    Codigo = 1,
                    Descricao = "Hemograma",
                    Valor = 30,

                },
                new Exame()
                {
                    Codigo = 2,
                    Descricao = "Cardiograma",
                    Valor = 60,
                }

        };

        [HttpGet]
        [Route("PedidoDeExames")]
        public async Task<IActionResult> GetExame()
        {

            return Ok(exames);
        }

        [HttpGet]
        [Route("PedidoDeExame")]
        public async Task<IActionResult> GetExame(int codigo)
        {
            var exame = exames.Find(x => x.Codigo == codigo);
            if(exame == null)
            {
                return BadRequest("Exame não encontrado!");
            }
            return Ok(exame);
        }


    }
}
