using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/desenvolvedora")]
public class DesenvolvedoraController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public DesenvolvedoraController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("desenvolvedora/list")]
    public async Task<ActionResult<IEnumerable<DesenvolvedoraModel>>> List()
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        return await _context.Desenvolvedora.ToListAsync();
    }

    [HttpGet()]
    [Route("desenvolvedora/find/{id}")]
    public async Task<ActionResult<DesenvolvedoraModel>> Find([FromRoute] string id)
    {
        if (_context?.Desenvolvedora is null)
            return NotFound();
        var desenvolvedora = await _context.Desenvolvedora.FindAsync(id);
        if (desenvolvedora is null)
            return NotFound();
        return desenvolvedora;
    }

    [HttpPost]
    [Route("desenvolvedora/create")]
    public async Task<ActionResult> Create(DesenvolvedoraModel desenvolvedora)
    {
        await _context.AddAsync(desenvolvedora);
        await _context.SaveChangesAsync();
        return Created("", desenvolvedora);
    }

    [HttpPut]
   [Route("desenvolvedora/alterar")]
   public async Task<ActionResult> Alterar(DesenvolvedoraModel desenvolvedora){
    _context.Update(desenvolvedora);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("desenvolvedora/mudardescricao/{id}")]
    public async Task<ActionResult> MudarNome(int id, [FromForm] string nome){
        var desenvolvedoraTemp = await _context.Desenvolvedora.FindAsync(id);

        if(desenvolvedoraTemp is null) return NotFound();
        desenvolvedoraTemp.nome = nome;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("desenvolvedora/excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var desenvolvedoraTemp = await _context.Desenvolvedora.FindAsync(id);

        if(desenvolvedoraTemp is null) return NotFound();
        _context.Desenvolvedora.Remove(desenvolvedoraTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}