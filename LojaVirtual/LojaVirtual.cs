using LojaVirtual.Aspects;

namespace LojaVirtual;

public class LojaVirtual {
    private List<Pedido> Pedidos = [];
    public static bool UsuarioAutenticado = false;
    
    [Notification]
    [Auth]
    [Auditoria]
    public void CadastrarPedido(Pedido pedido) {
        Pedidos.Add(pedido);
    }
    
    [Auth]
    [Auditoria]
    public List<Pedido> ListarPedidos() {
        return Pedidos;
    }
    
    [Notification]
    [Auth]
    [Auditoria]
    public void AlterarPedidos(int id, Pedido novoPedido) {
        foreach (var pedido in Pedidos.ToList().Where(pedido => pedido.Id == id))
        {
            Pedidos.Remove(pedido);
            Pedidos.Add(novoPedido);
        }
    }

    public void Login(string email, string senha)
    {
        if (email == "admin" && senha == "admin")
            UsuarioAutenticado = true;
    }
    
    [Notification]
    [Exception]
    [Auth]
    [Auditoria]
    public void CadastrarPedidoComExcecao(Pedido pedido)
    {
        throw new ArgumentOutOfRangeException(nameof(pedido));
    }
}