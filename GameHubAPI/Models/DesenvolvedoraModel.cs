using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameHubAPI.Models
{
    public class DesenvolvedoraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public required string nome { get; set; }
        public required string porte { get; set; }

        public ICollection<JogoModel>? jogos { get; set; }
    }
}
