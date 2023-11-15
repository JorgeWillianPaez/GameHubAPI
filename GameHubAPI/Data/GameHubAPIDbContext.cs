using Microsoft.EntityFrameworkCore;
using GameHubAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GameHubAPI.Data;
public class GameHubAPIDbContext : DbContext
{
    public DbSet<AmizadeModel>? Amizade { get; set; }
    public DbSet<BibliotecaModel>? Biblioteca { get; set; }
    public DbSet<CategoriaModel>? Categoria { get; set; }
    public DbSet<CompraModel>? Compra { get; set; }
    public DbSet<ConquistaModel>? Conquista { get; set; }
    public DbSet<DesenvolvedoraModel>? Desenvolvedoras { get; set; }
    public DbSet<GameplayConquistaModel>? GameplayConquista { get; set; }
    public DbSet<GameplayModel>? Gameplay { get; set; }
    public DbSet<ImagemJogoModel>? ImagemJogo { get; set; }
    public DbSet<JogoModel>? Jogos { get; set; }
    public DbSet<JogoCategoria>? JogosCategorias { get; set; }
    public DbSet<NoticiaModel>? Noticia { get; set; }
    public DbSet<ProgressoConquistaModel>? ProgressoConquista { get; set; }
    public DbSet<PromocaoModel>? Promocao { get; set; }
    public DbSet<UsuarioModel>? Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=database_name;user=username;password=password");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogoCategoria>()
                .HasKey(jc => new { jc.JogoId, jc.CategoriaId });

            modelBuilder.Entity<JogoCategoria>()
                .HasOne(jc => jc.Jogo)
                .WithMany(j => j.JogosCategorias)
                .HasForeignKey(jc => jc.JogoId);

            modelBuilder.Entity<JogoCategoria>()
                .HasOne(jc => jc.Categoria)
                .WithMany(c => c.JogosCategorias)
                .HasForeignKey(jc => jc.CategoriaId);

            modelBuilder.Entity<CompraJogo>()
                .HasKey(jc => new { jc.JogoId, jc.CompraId });

            modelBuilder.Entity<CompraJogo>()
                .HasOne(jc => jc.Jogo)
                .WithMany(j => j.CompraJogos)
                .HasForeignKey(jc => jc.JogoId);

            modelBuilder.Entity<CompraJogo>()
                .HasOne(jc => jc.Compra)
                .WithMany(c => c.CompraJogos)
                .HasForeignKey(jc => jc.CompraId);

            base.OnModelCreating(modelBuilder);
        }
}