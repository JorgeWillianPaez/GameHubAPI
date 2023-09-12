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

        public ConquistaModel(int id, int nome, string descricao, int pontos)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.pontos = pontos;
        }

        public void Inserir(ConquistaModel conquista)
        {
        }

        public void Alterar(int id, ConquistaModel novaConquista)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<ConquistaModel> ListarPorJogo(int idJogo)
        {
        }

        public ConquistaModel Buscar(int id)
        {
        }
    }
}
