using LabClinic.Entitie;
using Microsoft.AspNetCore.Mvc;


namespace LabClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoExameController : ControllerBase

    {
        private static List<Exame> exames = new List<Exame>()
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
        [HttpPost]
        [Route("AdcionarExame")]
        public async Task<IActionResult> AddExame(Exame  request)
        {
            exames.Add(request);
            return Ok(exames);
        }
        [HttpPut]
        [Route("AlterarExame")]
        public async Task<IActionResult> AtualizarExame(Exame request)
        {
            var exame = exames.Find(c => c.Codigo == request.Codigo);
            if (exame == null)
               return BadRequest("Não foi encontrar nenhum Exame!");
            exame.Descricao = request.Descricao;
            exame.Valor = request.Valor;
            return Ok(exames);
        }

        [HttpDelete]
        [Route("RemoverExame")]
        public async Task<IActionResult> RemoverExame(int codigo)
        {
            var exame = exames.Find(c => c.Codigo == codigo);
            if (exame == null)
                return BadRequest("Não foi encontrar nenhum Exame!");
            exames.Remove(exame);
            return Ok(exames);
        }
    }
}
