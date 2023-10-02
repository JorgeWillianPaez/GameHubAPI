using System.ComponentModel.DataAnnotations;
namespace GameHubAPI.Models
{
    public class CategoriaModel
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
    }
}
