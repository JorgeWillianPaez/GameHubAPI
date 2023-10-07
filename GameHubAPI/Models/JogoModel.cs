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
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime DataLancamento { get; set; }

        public int DesenvolvedoraId { get; set; }

        public DesenvolvedoraModel? Desenvolvedora { get; set; }

        public required ICollection<JogoCategoria> JogosCategorias { get; set; }

        public ICollection<CompraJogo>? CompraJogos { get; set; }
    }
}
