using LojaVirtual.Aspects;

namespace LojaVirtual;

public class LojaVirtual {
    private List<Pedido> Pedidos = [];
    
    [Notification]
    [Auditoria]
    public void CadastrarPedido(Pedido pedido) {
        Pedidos.Add(pedido);
    }

    [Auditoria]
    public List<Pedido> ListarPedidos() {
        return Pedidos;
    }
    
    [Notification]
    [Auditoria]
    public void AlterarPedidos(int id, Pedido novoPedido) {
        foreach (var pedido in Pedidos.ToList().Where(pedido => pedido.Id == id))
        {
            Pedidos.Remove(pedido);
            Pedidos.Add(novoPedido);
        }
    }
}