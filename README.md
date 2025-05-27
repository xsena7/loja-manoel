# 🎮 Loja do Seu Manoel - API de Embalagens

📦 **Sistema automático para cálculo de caixas** de produtos de games

## ✨ Funcionalidades Principais
- **Cálculo inteligente** de caixas para N produtos
- **Otimização de espaço**: agrupa itens na menor caixa possível
- **3 tamanhos de caixa** pré-definidos:
• Caixa 1: 30x40x80cm
• Caixa 2: 80x50x40cm
• Caixa 3: 50x80x60cm

- **Documentação interativa** via Swagger

## 🚀 Como Usar
### Requisitos
- Docker ([Download](https://www.docker.com/get-started))
- Git

### Passo a Passo
bash
# 1. Clone o repositório
git clone https://github.com/xsena7/loja-manoel.git
cd loja-manoel

# 2. Inicie os containers
docker-compose up --build

# 3. Acesse no navegador:
#    • Swagger: http://localhost:5000/swagger
#    • API: http://localhost:5000/api/Embalagem

🧪 Testando a API
Exemplo de Request:

POST /api/Embalagem
[
  {
    "id": 1,
    "produtos": [
      {
        "id": 1,
        "nome": "PlayStation 5",
        "altura": 40,
        "largura": 30,
        "comprimento": 20
      }
    ]
  }
]

Exemplo de Response:

{
  "pedidoId": 1,
  "caixasUsadas": [
    {
      "caixaId": 1,
      "produtosIds": [1]
    }
  ]
}

🛠️ Tecnologias Usadas
Tecnologia	Função
.NET 9	Backend da API
SQL Server	Banco de dados
Docker	Containerização
Swagger	Documentação

⁉️ Dúvidas?
Abra uma Issue no GitHub ou me chame no [LinkedIn](https://www.linkedin.com/in/xsena7/)
