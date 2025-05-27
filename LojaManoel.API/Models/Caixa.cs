namespace LojaManoel.API.Models;

public class Caixa
{
    public string Tipo { get; set; } = "Caixa Padrão";
    public int Altura { get; set; }
    public int Largura { get; set; }
    public int Comprimento { get; set; }
    public int Volume => Altura * Largura * Comprimento;
    public List<Produto> Produtos { get; set; } = new(); // Lista de produtos dentro
}