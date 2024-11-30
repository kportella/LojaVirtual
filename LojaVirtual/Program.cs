// See https://aka.ms/new-console-template for more information

using LojaVirtual;

Console.WriteLine("Hello, World!");

var loja = new LojaVirtual.LojaVirtual();

loja.Login("admin", "admin");

loja.CadastrarPedido(new Pedido(1, "Kaue", ["Carro"], 1000));

loja.AlterarPedidos(1, new Pedido(1, "Kaue", ["Carro"], 1600));

loja.ListarPedidos();
