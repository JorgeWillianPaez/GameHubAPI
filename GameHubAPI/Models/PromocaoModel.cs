namespace GameHubAPI.Models
{
    public class PromocaoModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFinal { get; set; }
        public string status { get; set; }
        public CategoriaModel categoria { get; set; }

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
    }
}
