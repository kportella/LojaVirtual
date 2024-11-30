using LojaVirtual.Aspects;

namespace LojaVirtual;

public class LojaVirtual {
    private List<Pedido> Pedidos = [];
    
    [Notification]
    [Auth]
    public void CadastrarPedido(Pedido pedido) {
        Pedidos.Add(pedido);
    }
    
    [Auth]
    public List<Pedido> ListarPedidos() {
        return Pedidos;
    }
    
    [Notification]
    [Auth]
    public void AlterarPedidos(int id, Pedido novoPedido) {
        foreach (var pedido in Pedidos.ToList().Where(pedido => pedido.Id == id))
        {
            Pedidos.Remove(pedido);
            Pedidos.Add(novoPedido);
        }
    }
}