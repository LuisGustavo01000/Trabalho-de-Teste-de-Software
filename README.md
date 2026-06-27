# 🥋 BlackBelt

Sistema desenvolvido em **ASP.NET Core 8 MVC** para gerenciamento de usuários e instrutores, utilizando **Entity Framework Core** e **SQL Server**.

Este repositório contém a aplicação, o banco de dados e os testes automatizados do projeto.

---

# 📋 Pré-requisitos

Antes de executar o projeto, instale os seguintes programas:

- ✅ [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- ✅ SQL Server Express ou LocalDB
- ✅ Visual Studio 2022 ou Visual Studio Code com extensão C#
- ✅ Google Chrome (necessário para testes com Selenium)

---

# 📦 Clonando o Projeto

Clone o repositório e entre na pasta do projeto:

```bash
git clone (https://github.com/LuisGustavo01000/Trabalho-de-Teste-de-Software.git)

cd Trabalho-de-Testes
```

---

# 📥 Restaurando as Dependências

Na raiz do projeto execute:

```bash
dotnet restore
```

---

# 🗄️ Configuração do Banco de Dados

Verifique se o SQL Server LocalDB está em execução.

Confira se o arquivo:

```
src/BlackBelt/appsettings.Development.json
```

possui a string de conexão correta:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BlackBeltDB;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

Depois, entre na pasta da aplicação:

```bash
cd src/BlackBelt
```

Crie o banco de dados executando:

```bash
dotnet ef database update
```

---

# ▶️ Executando a Aplicação

Ainda dentro da pasta **src/BlackBelt**, execute:

```bash
dotnet run
```

Caso tudo esteja correto, será exibida uma mensagem semelhante a:

```text
Now listening on:
https://localhost:7XXX
```

A aplicação ficará disponível no navegador através do endereço informado.

---

# 👤 Usuário Administrador

Na primeira execução é criado automaticamente um usuário administrador.

| Campo | Valor |
|--------|-------|
| CPF | 12345678900 |
| Senha | 123 |

Também é aceito o atalho:

| Usuário | Senha |
|----------|--------|
| admin | admin |

---

# 🧪 Executando os Testes

O projeto utiliza **xUnit** juntamente com **Entity Framework Core InMemory**, portanto **não é necessário iniciar o banco de dados** para executar os testes.

Entre na pasta:

```bash
cd src/BlackBelt.Tests
```

Execute:

```bash
dotnet test
```

---

# ✅ Resultado Esperado

Se todos os testes forem executados com sucesso, o terminal exibirá algo semelhante a:

```text
Passed! - Failed: 0
Passed: 5
Skipped: 0
Total: 5

✓ BuscarUsuario_IdExistente_RetornaUsuario
✓ BuscarUsuario_IdInexistente_RetornaNull
✓ CadastrarUsuario_CpfUnico_RetornaUsuario
✓ CadastrarUsuario_CpfDuplicado_RetornaNull
✓ BuscarInstrutores_RetornaApenasInstrutores
```

---

# 🛠️ Tecnologias Utilizadas

| Tecnologia | Descrição |
|------------|-----------|
| ASP.NET Core 8 MVC | Framework principal |
| Entity Framework Core 9 | ORM |
| SQL Server / LocalDB | Banco de dados |
| xUnit | Testes unitários |
| EF Core InMemory | Banco em memória para testes |
| Razor Views | Interface da aplicação |
| Bootstrap | Estilização |

---

# 📁 Estrutura do Projeto

```text
Trabalho-de-Testes
│
├── src
│   ├── BlackBelt
│   │   ├── Controllers
│   │   ├── Models
│   │   ├── Views
│   │   ├── Data
│   │   └── Program.cs
│   │
│   └── BlackBelt.Tests
│       ├── RepositoryTests
│       └── ...
│
└── README.md
```

---

# 📌 Observações

- Utilize o **.NET 8 SDK**.
- O projeto foi desenvolvido utilizando **SQL Server LocalDB**.
- Os testes unitários utilizam banco em memória (**EF Core InMemory**).
- Caso haja alterações nas entidades, execute novamente:

```bash
dotnet ef database update
```
