namespace GameHubAPI.Models
{
    public class GameplayModel
    {
        public int id { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public JogoModel? jogo { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
