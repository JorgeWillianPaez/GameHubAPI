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
        public DateTime dataLancamento { get; set; }

        public int desenvolvedoraId { get; set; }

        public DesenvolvedoraModel? desenvolvedora { get; set; }

        public required ICollection<JogoCategoria> jogosCategorias { get; set; }

        public ICollection<CompraJogo>? compraJogos { get; set; }
    }
}
