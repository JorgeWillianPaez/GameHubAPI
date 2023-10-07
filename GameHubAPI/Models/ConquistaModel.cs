using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class ConquistaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Pontos { get; set; }

        public ConquistaModel()
        {
            Id = 0;
            Nome = string.Empty;
            Descricao = string.Empty;
            Pontos = 0;
        }

        public ConquistaModel(int id, string nome, string descricao, int pontos)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Pontos = pontos;
        }
    }
}
