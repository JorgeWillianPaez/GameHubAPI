namespace GameHubAPI.Models
{
    public class ProgressoConquistaModel
    {
        public int id { get; set; }
        public double progresso { get; set; }
        public ConquistaModel? conquista { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
