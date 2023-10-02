namespace GameHubAPI.Models
{
    public class ConquistaModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int pontos { get; set; }

        public ConquistaModel()
        {
            id = 0;
            nome = string.Empty;
            descricao = string.Empty;
            pontos = 0;
        }

        public ConquistaModel(int id, string nome, string descricao, int pontos)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.pontos = pontos;
        }
    }
}
