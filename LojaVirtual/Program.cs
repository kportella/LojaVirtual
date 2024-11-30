// See https://aka.ms/new-console-template for more information

using LojaVirtual;
using LojaVirtual.Aspects;

Console.WriteLine("Hello, World!");

var loja = new LojaVirtual.LojaVirtual();

loja.Login("admin", "admin");

loja.CadastrarPedido(new Pedido(1, "Kaue", ["Carro"], 1000));

loja.AlterarPedidos(1, new Pedido(1, "Kaue", ["Carro"], 1600));

loja.ListarPedidos();

Pedido p = new Pedido(1, "João", new List<string>(){"Máquina de Lavar" }, 200);

try { 
    loja.CadastrarPedidoComExcecao(p);
}
catch (Exception e)
{
    Console.WriteLine(e);
    var context = e.GetContextInfo();

    if (context != null)
    {
        Console.WriteLine("---with---");
        Console.Write(context);
        Console.WriteLine("----------");
    }
}
