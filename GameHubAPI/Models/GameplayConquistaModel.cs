namespace GameHubAPI.Models
{
    public class GameplayConquistaModel
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public ConquistaModel? conquista { get; set; }
        public GameplayModel? gameplay { get; set; }
    }
}
