using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class BibliotecaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
