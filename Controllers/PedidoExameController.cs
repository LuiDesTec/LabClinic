﻿using LabClinic.Data;
using LabClinic.Entitie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LabClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoExameController : ControllerBase

    {

        private readonly ConexãoDBContext _dbContext;

        public PedidoExameController(ConexãoDBContext conexaodbContext)
        {
            _dbContext = conexaodbContext;
        }

        [HttpGet]
        [Route("PedidoDeExames")]
        public async Task<IActionResult> GetExame()
        {


            await _dbContext.Exames.ToListAsync();
            return Ok();
        }

        [HttpGet]
        [Route("PedidoDeExame")]
        public async Task<IActionResult> GetExame(int id)
        {
            var exame = _dbContext.Exames.FirstOrDefault(x => x.Id == id);
            if (exame == null)
            {
                return BadRequest("Exame não encontrado!");
            }
            _dbContext.Exames.Add(exame);
            return Ok();

        }

        [HttpPost]
        [Route("AdcionarExame")]
        public async Task<IActionResult> AddExame(Exame request)
        {
           
            
                _dbContext.Exames.Add(request);
                await _dbContext.SaveChangesAsync();
                return Created ($"AdicionarExame/{request.Id}", request.Id);



        }
        
        [HttpPut]
        [Route("AlterarExame")]
        public async Task<IActionResult> AtualizarExame(Exame request)
        {
            var exame = _dbContext.Exames.FirstOrDefault(x => x.Id == request.Id);
            if (exame == null)
               return BadRequest("Não foi encontrar nenhum Exame!");
            exame.Descricao = request.Descricao;
            exame.Valor = request.Valor;
            return Ok(_dbContext.Exames);
        }
       
        [HttpDelete]
        [Route("RemoverExame")]
        public async Task<IActionResult> RemoverExame(int id)
        {
            var exame = _dbContext.Exames.FirstOrDefault(c => c.Id == id);
            if (exame == null)
                return BadRequest("Não foi encontrar nenhum Exame!");
            _dbContext.Exames.Remove(exame);
            return Ok();
        } 
    }

}
