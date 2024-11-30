using LojaVirtual.Aspects;

namespace LojaVirtual;

public class LojaVirtual {
    private List<Pedido> Pedidos = [];
    
    [Notification]
    public void CadastrarPedido(Pedido pedido) {
        Pedidos.Add(pedido);
    }
    
    public List<Pedido> ListarPedidos() {
        return Pedidos;
    }
    
    [Notification]
    public void AlterarPedidos(int id, Pedido novoPedido) {
        foreach (var pedido in Pedidos.ToList().Where(pedido => pedido.Id == id))
        {
            Pedidos.Remove(pedido);
            Pedidos.Add(novoPedido);
        }
    }
}