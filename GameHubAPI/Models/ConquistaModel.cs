namespace GameHubAPI.Models
{
    public class ConquistaModel
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private int _pontos;

        public Conquista()
        {
            _id = 0;
            _nome = string.Empty;
            _descricao = string.Empty;
            _pontos = 0;
        }

        public Conquista(int id, int nome, string descricao, int pontos)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
            _pontos = pontos;
        }

        public void Inserir(Conquista conquista)
        {
        }

        public void Alterar(int id, Conquista novaConquista)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<Conquista> ListarPorJogo(int idJogo)
        {
        }

        public Conquista Buscar(int id)
        {
        }
    }
}
