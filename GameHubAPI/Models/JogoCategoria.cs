using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class JogoCategoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int jogoId { get; set; }
        public JogoModel? jogo { get; set; }
        public int categoriaId { get; set; }
        public CategoriaModel? categoria { get; set; }
    }
}
