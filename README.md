# 🎮 Loja do Seu Manoel - API de Embalagens

<div align="center">
  <img src="https://img.shields.io/badge/.NET-9-512BD4?logo=dotnet" alt=".NET 9">
  <img src="https://img.shields.io/badge/SQL_Server-2022-CC2927?logo=microsoft-sql-server" alt="SQL Server">
  <img src="https://img.shields.io/badge/Docker-2.0-2496ED?logo=docker" alt="Docker">
</div>

## ✨ Funcionalidades
- **Cálculo automático** de caixas ideais para produtos
- **Otimização inteligente** de espaço (agrupa itens quando possível)
- **3 modelos de caixa** pré-definidos:
  - `P` (30x40x80cm)
  - `M` (80x50x40cm)
  - `G` (50x80x60cm)

## 🚀 Como Executar
# 1. Clone o repositório
git clone https://github.com/xsena7/loja-manoel.git
cd loja-manoel

# 2. Inicie os containers
docker-compose up --build

# 3. Acesse:
#    Swagger: http://localhost:5000/swagger
#    API: http://localhost:5000/api/Embalagem

## 🧩 Exemplo de Uso
POST /api/Embalagem
[
  {
    "id": 1,
    "produtos": [
      {
        "id": 1,
        "nome": "Console Xbox",
        "altura": 15,
        "largura": 30,
        "comprimento": 25
      }
    ]
  }
]

## Response: 
{
  "pedidoId": 1,
  "caixasUsadas": [
    {
      "caixaId": 1,
      "produtosIds": [1]
    }
  ]
}

## 👨‍💻 Tecnologias
Backend: .NET 9
Banco de Dados: SQL Server 2022
Containerização: Docker
Documentação: Swagger UI


## 📞 Contato
[LinkedIn](https://www.linkedin.com/in/xsena7/)

