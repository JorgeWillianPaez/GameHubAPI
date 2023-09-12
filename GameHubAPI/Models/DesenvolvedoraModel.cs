namespace GameHubAPI.Models
{
    public class DesenvolvedoraModel
    {
        public int id;
        public string nome;
        public string porte;
        public CategoriaModel categoria;

        public DesenvolvedoraModel()
        {
            id = 0;
            nome = string.Empty;
            porte = string.Empty;
            categoria = null;
        }

        public DesenvolvedoraModel(int id, string nome, string porte, CategoriaModel categoria)
        {
            this.id = id;
            this.nome = nome;
            this.porte = porte;
            this.categoria = categoria;
        }

        public void InserirDesenvolvedora()
        {
        }

        public void Alterar(int id, DesenvolvedoraModel novaDesenvolvedora)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<DesenvolvedoraModel> Listar(string idCategoria)
        {
        }

        public DesenvolvedoraModel Buscar(int id)
        {
        }
    }

    
}

