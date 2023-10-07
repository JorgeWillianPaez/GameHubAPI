namespace GameHubAPI.Models
{
    public class CompraJogo
    {
        public int JogoId { get; set; }
        public JogoModel? Jogo { get; set; }

        public int CompraId { get; set; }
        public CompraModel? Compra { get; set; }
    }
}
