namespace LojaManoel.API.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "Novo Produto"; // Valor padrão
    public int Altura { get; set; }  // em centímetros
    public int Largura { get; set; } // em centímetros
    public int Comprimento { get; set; } // em centímetros

    // Calcula automaticamente o volume
    public int Volume => Altura * Largura * Comprimento;
}