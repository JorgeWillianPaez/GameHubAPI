using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/conquista")]
public class ConquistaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public ConquistaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("conquista/list")]
    public async Task<ActionResult<IEnumerable<ConquistaModel>>> List()
    {
        if (_context?.Conquista is null)
            return NotFound();
        return await _context.Conquista.ToListAsync();
    }

    [HttpGet()]
    [Route("conquista/find/{id}")]
    public async Task<ActionResult<ConquistaModel>> Find([FromRoute] string id)
    {
        if (_context?.Conquista is null)
            return NotFound();
        var conquista = await _context.Conquista.FindAsync(id);
        if (conquista is null)
            return NotFound();
        return conquista;
    }

    [HttpPost]
    [Route("conquista/create")]
    public async Task<ActionResult> Create(ConquistaModel conquista)
    {
        await _context.AddAsync(conquista);
        await _context.SaveChangesAsync();
        return Created("", conquista);
    }

     [HttpPut]
   [Route("conquista/alterar")]
   public async Task<ActionResult> Alterar(ConquistaModel conquista){
    _context.Update(conquista);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("conquista/mudardescricao/{id}")]
    public async Task<ActionResult> MudarDescricao(int id, [FromForm] string descricao){
        var conquistaTemp = await _context.Conquista.FindAsync(id);

        if(conquistaTemp is null) return NotFound();
        conquistaTemp.descricao = descricao;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("conquista/excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var conquistaTemp = await _context.Conquista.FindAsync(id);

        if(conquistaTemp is null) return NotFound();
        _context.Conquista.Remove(conquistaTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}