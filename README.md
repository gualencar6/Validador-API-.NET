# 🔎 Validador de Dados API

API desenvolvida em ASP.NET Core para validação de dados como CPF, IP e Senha.

## 🚀 Funcionalidades

* ✔ Validação de CPF
* ✔ Validação de IP
* ✔ Validação de Senha

## 🛠 Tecnologias utilizadas

* .NET
* ASP.NET Core Web API
* Swagger

## ▶️ Como executar

Abra o arquivo e roda no terminal: dotnet run

Acesse no navegador:

http://localhost:xxxx/swagger


## 📌 Endpoints

### Validar CPF

POST /api/validador/cpf

```json
{
  "cpf": "12345678900"
}
```

### Validar IP

POST /api/validador/ip

```json
{
  "ip": "192.168.0.1"
}
```

### Validar Senha

POST /api/validador/senha

```json
{
  "senha": "Senha@123"
}
```

## 💡 Sobre o projeto

Este projeto foi criado como evolução de uma aplicação console para uma API REST, com foco em boas práticas de organização (Controller, Service e Models).
