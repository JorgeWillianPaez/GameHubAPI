using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameHubAPI.Models;
    

    public class NoticiaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? titulo { get; set; }
        public string? descricao { get; set; }
        public DateTime dataPublicacao { get; set; }
        public int? UsuarioId { get; set; }
        public UsuarioModel? usuario { get; set; }
        public int? categoriaId { get; set; }
        public CategoriaModel? categoria { get; set; }
    }
