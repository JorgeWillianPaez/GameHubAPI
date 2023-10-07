using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameHubAPI.Models
{
    public class CompraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public double Total { get; set; }
        public string? MetodoPagamento { get; set; }
        public UsuarioModel? Usuario { get; set; }

        public required ICollection<CompraJogo> CompraJogos { get; set; }
    }
}
