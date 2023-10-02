using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using GameHubAPI.Data;
using GameHubAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameHubAPI.Controllers;

[ApiController]
[Route("gamehubapi/categoria")]
public class CategoriaController : ControllerBase
{
    private GameHubAPIDbContext? _context;

    public CategoriaController(GameHubAPIDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("categoria/list")]
    public async Task<ActionResult<IEnumerable<CategoriaModel>>> List()
    {
        if (_context?.Categoria is null)
            return NotFound();
        return await _context.Categoria.ToListAsync();
    }

    [HttpGet()]
    [Route("categoria/find/{id}")]
    public async Task<ActionResult<CategoriaModel>> Find([FromRoute] string id)
    {
        if (_context?.Categoria is null)
            return NotFound();
        var categoria = await _context.Categoria.FindAsync(id);
        if (categoria is null)
            return NotFound();
        return categoria;
    }

    [HttpPost]
    [Route("categoria/create")]
    public async Task<ActionResult> Create(CategoriaModel categoria)
    {
        await _context.AddAsync(categoria);
        await _context.SaveChangesAsync();
        return Created("", categoria);
    }

    [HttpPut]
   [Route("categoria/alterar")]
   public async Task<ActionResult> Alterar(CategoriaModel categoria){
    _context.Update(categoria);
    await _context.SaveChangesAsync();
    return Ok();
   }

   [HttpPatch]
   [Route("categoria/mudardescricao/{id}")]
    public async Task<ActionResult> MudarDescricao(int id, [FromForm] string descricao){
        var categoriaTemp = await _context.Categoria.FindAsync(id);

        if(categoriaTemp is null) return NotFound();
        categoriaTemp.descricao = descricao;

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    [Route("categoria/excluir/{id}")]
    public async Task<ActionResult> Excluir(int id){
        var categoriaTemp = await _context.Categoria.FindAsync(id);

        if(categoriaTemp is null) return NotFound();
        _context.Categoria.Remove(categoriaTemp);
        await _context.SaveChangesAsync();
        return Ok();
    }
}