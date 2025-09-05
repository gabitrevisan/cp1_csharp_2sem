# 📚 Checkpoint 01 de C# Software Development (2.2025)

*Turma:* 3ESPW
*Aluna:* Gabriela Trevisan da Silva
*RM:* 99500

## 🎯 Objetivo

Este projeto tem como objetivo criar uma API RESTful utilizando arquitetura modular em .NET. A aplicação se conecta a um banco de dados Oracle para persistência de dados, seguindo boas práticas de desenvolvimento e separação de responsabilidades.

---

## 🧱 Estrutura do Projeto

A solução está organizada em três projetos principais, cada um com sua responsabilidade específica:

-   `Checkpoint.Api`: Responsável por expor os endpoints da API. É o projeto principal que executa a aplicação web.
-   `Checkpoint.Model`: Contém as entidades (modelos) de dados da aplicação, como `Produto`, `Pedido` e `Fornecedor`.
-   `Checkpoint.Data`: Camada de acesso a dados, responsável pela comunicação com o banco de dados Oracle utilizando Entity Framework Core. Contém o `DbContext` e as migrações.

---

## 🛠️ Tecnologias Utilizadas

-   .NET 8
-   ASP.NET Core
-   Entity Framework Core 8
-   Oracle Database
-   Swagger/OpenAPI

---

## 🚀 Como Executar o Projeto

### 🔧 Pré-requisitos

-   .NET 8 SDK
-   Acesso a um Banco de Dados Oracle
-   Ferramenta para testes de API (Postman, Insomnia, ou o próprio Swagger UI)

---

### 🏁 Passos

1.  **Clone o repositório:**
    ```bash
    git clone <URL_DO_REPOSITORIO>
    ```

2.  **Ajuste a Connection String:**
    -   Abra o arquivo `Checkpoint/Checkpoint.Api/appsettings.json`.
    -   Modifique a `DefaultConnection` com as credenciais do seu banco de dados Oracle.

3.  **Acesse a pasta da API:**
    ```bash
    cd Checkpoint/Checkpoint.Api
    ```

4.  **Restaure os pacotes:**
    ```bash
    dotnet restore
    ```

5.  **Aplique as migrations:**
    O projeto já contém as migrações necessárias para criar as tabelas no banco de dados. Execute o comando abaixo para aplicá-las.
    ```bash
    dotnet ef database update --project ../Checkpoint.Data
    ```

6.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```
