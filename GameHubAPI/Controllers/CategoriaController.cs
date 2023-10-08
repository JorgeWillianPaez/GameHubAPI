using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/[controller]")]
public class CategoriaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public CategoriaController(GameHubAPIDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<CategoriaModel>>> Listar()
    {
        if (_context?.Categoria is null)
            return NotFound();
        return await _context.Categoria.ToListAsync();
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<ActionResult<CategoriaModel>> Buscar([FromRoute] int id)
    {
        if (_context?.Categoria is null)
            return NotFound();
        var categoria = await _context.Categoria.FindAsync(id);
        if (categoria is null)
            return NotFound();
        return categoria;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult> Inserir(CategoriaModel categoria)
    {
       await _context.AddAsync(categoria);
       await _context.SaveChangesAsync();
        return Created("", categoria);
    }

        [HttpPut]
   [Route("alterar")]
   public async Task<ActionResult> Alterar(CategoriaModel categoria){
    _context.Update(categoria);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("mudardescricao/{id}")]
    public async Task<ActionResult> MudarDescricao(int id, [FromForm] string nome){
        var nomeTemp = await _context.Categoria.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        nomeTemp.Nome = nome;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var nomeTemp = await _context.Categoria.FindAsync(id);

        if(nomeTemp is null) return NotFound();
        _context.Categoria.Remove(nomeTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}