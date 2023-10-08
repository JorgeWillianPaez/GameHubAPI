using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class PromocaoController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public PromocaoController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<PromocaoModel>>> Listar()
    {
        if (_context?.Promocao is null)
            return NotFound();
        return await _context.Promocao.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<PromocaoModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Promocao is null)
            return NotFound();
        var promocao = await _context.Promocao.FindAsync(id);
        if (promocao is null)
            return NotFound();
        return promocao;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Inserir(PromocaoModel promocao)
    {
        await _context.AddAsync(promocao);
        await _context.SaveChangesAsync();
        return Created("", promocao);
    }

        [HttpPut]
   [Route("alterar")]
   public async Task<ActionResult> Alterar(PromocaoModel promocao){
    _context.Update(promocao);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("mudardescricao/{id}")]
    public async Task<ActionResult> MudarDescricao(int id, [FromForm] string nome){
        var nomeTemp = await _context.Promocao.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        nomeTemp.nome = nome;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var nomeTemp = await _context.Promocao.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        _context.Promocao.Remove(nomeTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}