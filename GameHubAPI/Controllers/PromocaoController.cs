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
    public IActionResult Create(PromocaoModel promocao)
    {
        _context?.Add(promocao);
        _context?.SaveChanges();
        return Created("", promocao);
    }
}