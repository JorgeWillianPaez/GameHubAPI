namespace GameHubAPI.Models
{
    public class DesenvolvedoraModel
    {
        private int _id;
        private string _nome;
        private string _porte;
        private Categoria _categoria;

        public Desenvolvedora()
        {
            _id = 0;
            _nome = string.Empty;
            _porte = string.Empty;
            _categoria = null;
        }

        public Desenvolvedora(int id, string nome, string porte, Categoria categoria)
        {
            _id = id;
            _nome = nome;
            _porte = porte;
            _categoria = categoria;
        }

        public void InserirDesenvolvedora()
        {
        }

        public void Alterar(int id, Desenvolvedora novaDesenvolvedora)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<Desenvolvedora> Listar(string idCategoria)
        {
        }

        public Desenvolvedora Buscar(int id)
        {
        }
    }

    
}

