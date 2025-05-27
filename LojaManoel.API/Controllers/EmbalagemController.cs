using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LojaManoel.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmbalagemController : ControllerBase
    {
        // Caixas disponíveis pré-definidas
        private readonly List<Caixa> _caixasDisponiveis = new()
        {
            new Caixa { Id = 1, Altura = 30, Largura = 40, Comprimento = 80 },
            new Caixa { Id = 2, Altura = 80, Largura = 50, Comprimento = 40 },
            new Caixa { Id = 3, Altura = 50, Largura = 80, Comprimento = 60 }
        };

        /// <summary>
        /// Calcula a melhor combinação de caixas para os produtos
        /// </summary>
        [HttpPost]
        public ActionResult<List<EmbalagemResponse>> CalcularEmbalagem(List<Pedido> pedidos)
        {
            var resultados = new List<EmbalagemResponse>();
            
            // Ordena caixas por volume (menor primeiro)
            var caixasOrdenadas = _caixasDisponiveis
                .OrderBy(c => c.Altura * c.Largura * c.Comprimento)
                .ToList();

            foreach (var pedido in pedidos)
            {
                var resultado = new EmbalagemResponse
                {
                    PedidoId = pedido.Id,
                    CaixasUsadas = new List<CaixaUsada>()
                };

                var produtosRestantes = pedido.Produtos.ToList();
                
                while (produtosRestantes.Any())
                {
                    var produtoAtual = produtosRestantes.First();
                    
                    // Encontra a menor caixa que cabe o produto atual
                    var caixa = caixasOrdenadas
                        .FirstOrDefault(c => c.Altura >= produtoAtual.Altura &&
                                           c.Largura >= produtoAtual.Largura &&
                                           c.Comprimento >= produtoAtual.Comprimento);

                    if (caixa == null) break; // Se não achar caixa, interrompe

                    // Agrupa produtos que cabem na mesma caixa
                    var produtosNaCaixa = produtosRestantes
                        .Where(p => p.Altura <= caixa.Altura &&
                                   p.Largura <= caixa.Largura &&
                                   p.Comprimento <= caixa.Comprimento)
                        .ToList();

                    resultado.CaixasUsadas.Add(new CaixaUsada
                    {
                        CaixaId = caixa.Id,
                        ProdutosIds = produtosNaCaixa.Select(p => p.Id).ToList()
                    });

                    // Remove os produtos já embalados
                    produtosRestantes = produtosRestantes
                        .Except(produtosNaCaixa)
                        .ToList();
                }

                resultados.Add(resultado);
            }

            return Ok(resultados);
        }
    }
}