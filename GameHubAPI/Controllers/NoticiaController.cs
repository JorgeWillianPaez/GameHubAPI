using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class NoticiaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public NoticiaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<NoticiaModel>>> Listar()
    {
        if (_context?.Noticia is null)
            return NotFound();
        return await _context.Noticia.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<NoticiaModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Noticia is null)
            return NotFound();
        var noticia = await _context.Noticia.FindAsync(id);
        if (noticia is null)
            return NotFound();
        return noticia;
    }

    [HttpPost]
    [Route("")]
    public IActionResult Inserir(NoticiaModel noticia)
    {
        _context?.Add(noticia);
        _context?.SaveChanges();
        return Created("", noticia);
    }

        [HttpPut]
   [Route("alterar")]
   public async Task<ActionResult> Alterar(NoticiaModel noticia){
    _context.Update(noticia);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("mudartitulo/{id}")]
    public async Task<ActionResult> MudarTitulo(int id, [FromForm] string nome){
        var nomeTemp = await _context.Noticia.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        nomeTemp.Titulo = nome;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var nomeTemp = await _context.Noticia.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        _context.Noticia.Remove(nomeTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}