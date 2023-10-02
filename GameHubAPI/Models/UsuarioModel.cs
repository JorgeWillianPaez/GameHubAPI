using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace GameHubAPI.Models
{
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? nickName { get; set; }
        public string? email { get; set; }
        public DateOnly dataNascimento { get; set; }
        public string? senha { get; set;}
        public string? status { get; set;}
        public bool usuarioAtivado { get; set;}
    }
}
