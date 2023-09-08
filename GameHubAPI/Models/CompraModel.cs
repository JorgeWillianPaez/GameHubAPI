using Microsoft.AspNetCore.Routing.Constraints;

namespace GameHubAPI.Models
{
    public class CompraModel
    {
        private int id;
        private DateTime dataCompra;
        private float total;
        private string metodoPagamento;
        private UsuarioModel usuario;

        public int Id
        {
            get => id;
            set => id = value;
        }
        public DateTime DataCompra
        {
            get => dataCompra;
            set => dataCompra = value;
        }
        public float Total
        {
            get => total;
            set => total = value;
        }
        public string MetodoPagamento
        {
            get => metodoPagamento;
            set => metodoPagamento = value;
        }
        public UsuarioModel Usuario
        {
            get => usuario;
            set => usuario = value;
        }
    }
}
