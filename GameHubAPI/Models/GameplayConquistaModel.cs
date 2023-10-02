using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameHubAPI.Models
{
    public class GameplayConquistaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime data { get; set; }
        public ConquistaModel? conquista { get; set; }
        public GameplayModel? gameplay { get; set; }
    }
}
