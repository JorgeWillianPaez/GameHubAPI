namespace GameHubAPI.Models
{
    public class PromocaoModel
    {
        public int id;
        public string nome;
        public DateTime dataInicio;
        public DateTime dataFinal;
        public string status;
        public CategoriaModel categoria;

        public PromocaoModel()
        {
            id = 0;
            nome = string.Empty;
            dataInicio = DateTime.MinValue;
            dataFinal = DateTime.MinValue;
            status = string.Empty;
            categoria = null;
        }

        public PromocaoModel(int id, string nome, DateTime dataInicio, DateTime dataFinal, string status, CategoriaModel categoria)
        {
            this.id = id;
            this.nome = nome;
            this.dataInicio = dataInicio;
            this.dataFinal = dataFinal;
            this.status = status;
            this.categoria = categoria;
        }

        public void Inserir(PromocaoModel promocao)
        {
        }

        public void Alterar(int id, PromocaoModel novaPromocao)
        {
        }

        public List<PromocaoModel> Listar(string status)
        {
        }

        public PromocaoModel Buscar(int id)
        {
        }
    }
}
