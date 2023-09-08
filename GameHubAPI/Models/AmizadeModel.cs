namespace GameHubAPI.Models
{
    public class Amizade
    {
        private int id;
        private UsuarioModel usuario1;
        private UsuarioModel usuario2;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public UsuarioModel Usuario1
        {
            get => usuario1;
            set => usuario1 = value;
        }
        public UsuarioModel Usuario2
        {
            get => usuario2;
            set => usuario2 = value;
        }
    }
}
