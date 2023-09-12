namespace GameHubAPI.Models
{
    public class NoticiaModel
    {
        public int id;
        public string titulo;
        public string assunto;
        public DateTime descricao;
        public UsuarioModel usuario;
        public CategoriaModel categoria;

        public NoticiaModel()
        {
            id = 0;
            titulo = string.Empty;
            assunto = string.Empty;
            descricao = DateTime.MinValue;
            usuario = null;
            categoria = null;
        }

        public NoticiaModel(int id, string titulo, string assunto, DateTime descricao, UsuarioModel usuario, CategoriaModel categoria)
        {
            this.id = id;
            this.titulo = titulo;
            this.assunto = assunto;
            this.descricao = descricao;
            this.usuario = usuario;
            this.categoria = categoria;
        }

        public void Inserir(NoticiaModel noticia)
        {
        }

        public void Alterar(int id, NoticiaModel novaNoticia)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<NoticiaModel> Listar()
        {
        }

        public NoticiaModel Buscar(int id)
        {
        }
    }
}
