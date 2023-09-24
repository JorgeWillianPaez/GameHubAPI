namespace GameHubAPI.Models
{
    public class ConquistaModel
    {
        public int id;
        public string nome;
        public string descricao;
        public int pontos;

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
