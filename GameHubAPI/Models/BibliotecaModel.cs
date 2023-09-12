namespace GameHubAPI.Models
{
    public class BibliotecaModel
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
