namespace GameHubAPI.Models
{
    public class JogoCategoria
    {
        public int JogoId { get; set; }
        public JogoModel? Jogo { get; set; }

        public int CategoriaId { get; set; }
        public CategoriaModel? Categoria { get; set; }
    }
}
