namespace GameHubAPI.Models
{
    public class ProgressoConquista
    {
        public int id { get; set; }
        public double progresso { get; set; }
        public ConquistaModel? conquista { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
