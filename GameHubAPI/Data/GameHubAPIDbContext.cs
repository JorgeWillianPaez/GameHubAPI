using Microsoft.EntityFrameworkCore;
using GameHubAPI.Models;
namespace GameHubAPI.Data;
public class GameHubAPIDbContext : DbContext
{
    public DbSet<Amizade>? Amizade { get; set; }
    public DbSet<BibliotecaModel>? BibliotecaModel { get; set; }
    public DbSet<CategoriaModel>? Categoria { get; set; }
    public DbSet<CompraModel>? Compra { get; set; }
    public DbSet<ConquistaModel>? Conquista { get; set; }
    public DbSet<DesenvolvedoraModel>? Desenvolvedora { get; set; }
    public DbSet<GameplayConquistaModel>? GameplayConquista { get; set; }
    public DbSet<ImagemJogoModel>? ImagemJogo { get; set; }
    public DbSet<JogoModel>? Jogo { get; set; }
    public DbSet<NoticiaModel>? Noticia { get; set; }
    public DbSet<ProgressoConquista>? ProgressoConquista { get; set; }
    public DbSet<PromocaoModel>? Promocao { get; set; }
    public DbSet<UsuarioModel>? Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=gamehub.db;Cache=Shared;");
    }
}