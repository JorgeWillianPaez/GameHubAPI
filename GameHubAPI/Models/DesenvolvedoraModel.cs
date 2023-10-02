using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class DesenvolvedoraModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string nome { get; set; }
        public string porte { get; set; }
        public CategoriaModel categoria { get; set; }

        public DesenvolvedoraModel()
        {
            id = 0;
            nome = string.Empty;
            porte = string.Empty;
            categoria = null!;
        }

        public DesenvolvedoraModel(int id, string nome, string porte, CategoriaModel categoria)
        {
            this.id = id;
            this.nome = nome;
            this.porte = porte;
            this.categoria = categoria;
        }
    }

    
}

