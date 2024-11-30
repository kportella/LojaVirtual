namespace LojaVirtual;
public record Pedido(int Id, string Cliente, List<string> Produtos, double ValorTotal);