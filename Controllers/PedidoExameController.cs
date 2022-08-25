using LabClinic.Entitie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoExameController : ControllerBase
    {
        [HttpGet]
        [Route("PedidoDeExame")]
        public async Task<IActionResult> GetExame() {

            var exame = new List<Exame>()
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
            return Ok(exame);
        }

       
    }
}
