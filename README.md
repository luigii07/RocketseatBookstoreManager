# 📚 Rocketseat Bookstore Manager

API REST desenvolvida em **C# e .NET** para gerenciamento de livros. O projeto foi desenvolvido durante os estudos na Rocketseat com foco em fundamentos de desenvolvimento backend e organização de uma API.

## 🚀 Sobre o Projeto

A API permite realizar operações de gerenciamento de livros, como:

* 📖 Cadastrar livros
* 🔎 Consultar livros
* ✏️ Atualizar livros
* 🗑️ Remover livros

O projeto utiliza **Controllers, Entities, Repositories e Enums**, aplicando separação de responsabilidades e injeção de dependências.

## 🛠️ Tecnologias

* C#
* .NET
* ASP.NET Core

## 📁 Estrutura

```text
├── Communication
│   ├── Request
│   │   ├── RequestCreateBookJson.cs
│   │   └── RequestUpdateBookJson.cs
│   └── Response
│       └── ResponseErrorJson.cs
├── Controllers
│   ├── BooksController.cs
│   └── BookstoreManagerBaseController.cs
├── Entities
│   └── Book.cs
├── Enums
│   └── Genre.cs
├── Repositories
│   ├── BooksRepository.cs
│   └── IBooksRepository.cs
├── Properties
│   └── launchSettings.json
├── Program.cs
├── appsettings.json
└── RocketseatBookstoreManager.csproj
```

### 📂 Principais componentes

* **Communication** — modelos utilizados nas requisições e respostas da API.
* **Controllers** — recebem e processam as requisições HTTP.
* **Entities** — representam as entidades do domínio, como `Book`.
* **Enums** — definem valores previamente estabelecidos, como os gêneros dos livros.
* **Repositories** — responsáveis pelo acesso e manipulação dos dados.
* **Program.cs** — configuração e inicialização da aplicação.

## 🎯 Conceitos praticados

* APIs REST
* HTTP Methods e Status Code
* Controllers
* Entities
* Enums
* Interfaces
* Repository Pattern
* Injeção de Dependência
* Separação de responsabilidades

## 📖 Estudos

Projeto desenvolvido como parte dos estudos de **C# e .NET na Rocketseat**.
