namespace GameHubAPI.Models
{
    public class NoticiaModel
    {
        private int _id;
        private string _titulo;
        private string _assunto;
        private DateTime _descricao;
        private Usuario _usuario;
        private Categoria _categoria;

        public Noticia()
        {
            _id = 0;
            _titulo = string.Empty;
            _assunto = string.Empty;
            _descricao = DateTime.MinValue;
            _usuario = null;
            _categoria = null;
        }

        public Noticia(int id, string titulo, string assunto, DateTime descricao, Usuario usuario, Categoria categoria)
        {
            _id = id;
            _titulo = titulo;
            _assunto = assunto;
            _descricao = descricao;
            _usuario = usuario;
            _categoria = categoria;
        }

        public void Inserir(Noticia noticia)
        {
        }

        public void Alterar(int id, Noticia novaNoticia)
        {
        }

        public bool Excluir(int id)
        {
        }

        public List<Noticia> Listar()
        {
        }

        public Noticia Buscar(int id)
        {
        }
    }
}
