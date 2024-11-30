using Metalama.Framework.Aspects;

namespace LojaVirtual.Aspects;

public class NotificationAttribute : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        if (meta.Target.Method.ToDisplayString() == "LojaVirtual.CadastrarPedido(Pedido)")
            Console.WriteLine($"Tentando cadastrar pedido.");
        
        if (meta.Target.Method.ToDisplayString() == "LojaVirtual.AlterarPedidos(int, Pedido)")
            Console.WriteLine($"Tentando alterar pedido.");
        
        try
        {
            return meta.Proceed();
        }
        finally
        {
            Console.WriteLine( $"Ação concluida." );
        }
    }
}