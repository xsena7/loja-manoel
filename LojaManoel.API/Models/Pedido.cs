public class Pedido
{
    public int Id { get; set; }
    public List<Produto> Produtos { get; set; }
}

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Altura { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }
}

public class Caixa
{
    public int Id { get; set; }
    public int Altura { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }
}

public class EmbalagemResponse
{
    public int PedidoId { get; set; }
    public List<CaixaUsada> CaixasUsadas { get; set; }
}

public class CaixaUsada
{
    public int CaixaId { get; set; }
    public List<int> ProdutosIds { get; set; }
}