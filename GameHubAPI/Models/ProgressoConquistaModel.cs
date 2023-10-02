using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class ProgressoConquistaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public double progresso { get; set; }
        public ConquistaModel? conquista { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
