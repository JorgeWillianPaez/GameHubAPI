using System.Net.Mail;

namespace GameHubAPI.Models
{
    public class UsuarioModel
    {
        private int id;
        private string nome;
        private string nickName;
        private string email;
        private DateOnly dataNascimento;
        private string senha;
        private string status;
        private string usuarioAtivado;

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
        public string NickName
        {
            get => nickName;
            set => nickName = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public DateOnly DataNascimento
        {
            get => dataNascimento;
            set => dataNascimento = value;
        }
        public string Senha
        {
            get => senha;
            set => senha = value;
        }
        public string Status
        {
            get => status;
            set => status = value;
        }
        public string UsuarioAtivado
        {
            get => usuarioAtivado;
            set => usuarioAtivado = value;
        }
    }
}
