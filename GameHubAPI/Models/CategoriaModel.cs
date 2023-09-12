namespace GameHubAPI.Models
{
    public class CategoriaModel
    {
        public int id;
        public string nome;
        public string descricao;

        public CategoriaModel()
        {
            id = 0;
            nome = string.Empty;
            descricao = string.Empty;
        }

        public CategoriaModel(int id, string nome, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }

        public void Inserir(CategoriaModel categoria)
        {
        }

        public void Alterar(int id, CategoriaModel novaCategoria)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<CategoriaModel> Listar()
        {
        }

        public List<CategoriaModel> ListarPorJogo(int idJogo)
        {
        }

        public CategoriaModel Buscar(int id)
        {
        }
    }
}
