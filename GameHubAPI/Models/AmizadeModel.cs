namespace GameHubAPI.Models
{
    public class Amizade
    {
        public int id { get; set; }
        public UsuarioModel? usuario1 { get; set; }
        public UsuarioModel? usuario2 { get; set; }
    }
}
