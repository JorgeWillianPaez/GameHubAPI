using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameHubAPI.Models
{
    public class AmizadeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public UsuarioModel? usuario1 { get; set; }
        public int? usuario1Id { get; set; }
        public UsuarioModel? usuario2 { get; set; }
        public int? usuario2Id { get; set; }
    }
}
