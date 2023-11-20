using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class DesenvolvedoraController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public DesenvolvedoraController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<DesenvolvedoraModel>>> Listar()
    {
        if (_context?.Desenvolvedoras is null)
            return NotFound();
        return await _context.Desenvolvedoras.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<DesenvolvedoraModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Desenvolvedoras is null)
            return NotFound();
        var desenvolvedora = await _context.Desenvolvedoras.FindAsync(id);
        if (desenvolvedora is null)
            return NotFound();
        return desenvolvedora;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Inserir(DesenvolvedoraModel desenvolvedora)
    {
        await _context.AddAsync(desenvolvedora);
        await _context.SaveChangesAsync();
        return Created("", desenvolvedora);
    }

    [HttpPut]
   [Route("")]
   public async Task<ActionResult> Alterar(DesenvolvedoraModel desenvolvedora){
    _context.Update(desenvolvedora);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("mudarnome/{id}")]
    public async Task<ActionResult> MudarNome(int id, [FromForm] string nome){
        var nomeTemp = await _context.Desenvolvedoras.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        nomeTemp.Nome = nome;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> Excluir(int id){
        var nomeTemp = await _context.Desenvolvedoras.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        _context.Desenvolvedoras.Remove(nomeTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}