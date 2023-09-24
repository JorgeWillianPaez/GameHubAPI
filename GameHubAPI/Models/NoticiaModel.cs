namespace GameHubAPI.Models;
    

    public class NoticiaModel
    { 
        public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataPublicacao { get; set; }
    public UsuarioModel? Usuario { get; set; }
    public CategoriaModel? Categoria { get; set; }
    }
