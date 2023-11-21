using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GameHubAPI.Models
{
    
    public class JogoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public required string nome { get; set; }
        public required string descricao { get; set; }
        public double preco { get; set; }
        public string? dataLancamento { get; set; }
        public string? plataforma { get; set; }
        public string? imagem { get; set; }
        public int desenvolvedoraId { get; set; }
        public DesenvolvedoraModel? desenvolvedora { get; set; }
        public int categoriaId { get; set; }
        public CategoriaModel? categoria { get; set; }
        public ICollection<CompraJogo>? compraJogos { get; set; }
    }
}
