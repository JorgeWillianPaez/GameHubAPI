using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class JogoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public double preco { get; set; }
        public DateOnly dataLancamento { get; set; }
        public DesenvolvedoraModel? desenvolvedora { get; set; }
    }
}
