namespace ListaPedidos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; } = string.Empty;
        public string Produto { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
    }
}
