using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/noticia")]
public class NoticiaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public NoticiaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("noticia/list")]
    public async Task<ActionResult<IEnumerable<NoticiaModel>>> List()
    {
        if (_context?.Noticia is null)
            return NotFound();
        return await _context.Noticia.ToListAsync();
    }

    [HttpGet()]
    [Route("noticia/find/{id}")]
    public async Task<ActionResult<NoticiaModel>> Find([FromRoute] string id)
    {
        if (_context?.Noticia is null)
            return NotFound();
        var noticia = await _context.Noticia.FindAsync(id);
        if (noticia is null)
            return NotFound();
        return noticia;
    }

    [HttpPost]
    [Route("noticia/create")]
    public async Task<ActionResult> Create(NoticiaModel noticia)
    {
        await _context.AddAsync(noticia);
        await _context.SaveChangesAsync();
        return Created("", noticia);
    }

     [HttpPut]
   [Route("noticia/alterar")]
   public async Task<ActionResult> Alterar(NoticiaModel noticia){
    _context.Update(noticia);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("noticia/mudardescricao/{id}")]
    public async Task<ActionResult> MudarNome(int id, [FromForm] string descricao){
        var noticiaTemp = await _context.Noticia.FindAsync(id);

        if(noticiaTemp is null) return NotFound();
        noticiaTemp.Descricao = descricao;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("noticia/excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var noticiaTemp = await _context.Noticia.FindAsync(id);

        if(noticiaTemp is null) return NotFound();
        _context.Noticia.Remove(noticiaTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}