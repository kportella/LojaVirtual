namespace LojaVirtual;

public class LojaVirtual {
    private List<Pedido> Pedidos = [];
    public void CadastrarPedido(Pedido pedido) {
        Pedidos.Add(pedido);
    }
    public List<Pedido> ListarPedidos() {
        return Pedidos;
    }
    public void AlterarPedidos(int id, Pedido novoPedido) {
        foreach (var pedido in Pedidos.ToList().Where(pedido => pedido.Id == id))
        {
            Pedidos.Remove(pedido);
            Pedidos.Add(novoPedido);
        }
    }
}