namespace GameHubAPI.Models
{
    public class BibliotecaModel
    {
        private int id;
        private string nome;
        private string descricao;
        private UsuarioModel usuario;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }
        public UsuarioModel Usuario
        {
            get => usuario;
            set => usuario = value;
        }
    }
}
