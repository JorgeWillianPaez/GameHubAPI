using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameHubAPI.Models
{
    public class CompraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime dataCompra { get; set; }
        public double total { get; set; }
        public string? metodoPagamento { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
