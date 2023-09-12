namespace GameHubAPI.Models
{
    public class PromocaoModel
    {
        private int _id;
        private string _nome;
        private DateTime _dataInicio;
        private DateTime _dataFinal;
        private string _status;
        private Categoria _categoria;

        public Promocao()
        {
            _id = 0;
            _nome = string.Empty;
            _dataInicio = DateTime.MinValue;
            _dataFinal = DateTime.MinValue;
            _status = string.Empty;
            _categoria = null;
        }

        public Promocao(int id, string nome, DateTime dataInicio, DateTime dataFinal, string status, Categoria categoria)
        {
            _id = id;
            _nome = nome;
            _dataInicio = dataInicio;
            _dataFinal = dataFinal;
            _status = status;
            _categoria = categoria;
        }

        public void Inserir(Promocao promocao)
        {
        }

        public void Alterar(int id, Promocao novaPromocao)
        {
        }

        public List<Promocao> Listar(string status)
        {
        }

        public Promocao Buscar(int id)
        {
        }
    }
}
