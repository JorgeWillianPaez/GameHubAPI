using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/promocao")]
public class PromocaoController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public PromocaoController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("promocao/list")]
    public async Task<ActionResult<IEnumerable<PromocaoModel>>> List()
    {
        if (_context?.Promocao is null)
            return NotFound();
        return await _context.Promocao.ToListAsync();
    }

    [HttpGet()]
    [Route("promocao/find/{id}")]
    public async Task<ActionResult<PromocaoModel>> Find([FromRoute] string id)
    {
        if (_context?.Promocao is null)
            return NotFound();
        var promocao = await _context.Promocao.FindAsync(id);
        if (promocao is null)
            return NotFound();
        return promocao;
    }

    [HttpPost]
    [Route("promocao/create")]
    public async Task<ActionResult> Create(PromocaoModel promocao)
    {
        await _context.AddAsync(promocao);
        await _context.SaveChangesAsync();
        return Created("", promocao);
    }

    [HttpPut]
   [Route("promocao/alterar")]
   public async Task<ActionResult> Alterar(PromocaoModel promocao){
    _context.Update(promocao);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("promocao/mudardescricao/{id}")]
    public async Task<ActionResult> MudarStatus(int id, [FromForm] string status){
        var promocaoTemp = await _context.Promocao.FindAsync(id);

        if(promocaoTemp is null) return NotFound();
        promocaoTemp.status = status;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("promocao/excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var promocaoTemp = await _context.Promocao.FindAsync(id);

        if(promocaoTemp is null) return NotFound();
        _context.Promocao.Remove(promocaoTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}