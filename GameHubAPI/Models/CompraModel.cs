using Microsoft.AspNetCore.Routing.Constraints;

namespace GameHubAPI.Models
{
    public class CompraModel
    {
        public int id { get; set; }
        public DateTime dataCompra { get; set; }
        public double total { get; set; }
        public string? metodoPagamento { get; set; }
        public UsuarioModel? usuario { get; set; }
    }
}
