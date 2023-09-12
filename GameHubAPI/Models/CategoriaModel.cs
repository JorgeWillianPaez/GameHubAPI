namespace GameHubAPI.Models
{
    public class CategoriaModel
    {
        private int _id;
        private string _nome;
        private string _descricao;

        public Categoria()
        {
            _id = 0;
            _nome = string.Empty;
            _descricao = string.Empty;
        }

        public Categoria(int id, string nome, string descricao)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
        }

        public void Inserir(Categoria categoria)
        {
        }

        public void Alterar(int id, Categoria novaCategoria)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<Categoria> Listar()
        {
        }

        public List<Categoria> ListarPorJogo(int idJogo)
        {
        }

        public Categoria Buscar(int id)
        {
        }
    }
}
