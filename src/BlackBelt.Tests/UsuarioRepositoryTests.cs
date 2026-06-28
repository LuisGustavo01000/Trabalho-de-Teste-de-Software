using BlackBelt.Context;
using BlackBelt.Models;
using BlackBelt.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlackBelt.Tests;

public class UsuarioRepositoryTests
{
    // Cria um contexto InMemory novo e isolado para cada teste
    private AppDbContext CriarContexto(string nomeBanco)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: nomeBanco)
            .Options;
        return new AppDbContext(options);
    }

    // CT-U01 – Buscar usuário existente por ID
    [Fact]
    public void BuscarUsuario_IdExistente_RetornaUsuario()
    {
        var context = CriarContexto("CT_U01");
        context.Usuarios.Add(new Usuario
        {
            Id = 1, Nome = "Teste", Cpf = "12345678900",
            Email = "teste@email.com", Telefone = "31999999999",
            Dt_Nascimento = new DateOnly(2000, 1, 1),
            Tipo_Usuario = "Instrutor", SenhaHash = "hash"
        });
        context.SaveChanges();

        var repo = new UsuarioRepository(context);
        var resultado = repo.BuscarUsuario(1);

        Assert.NotNull(resultado);
        Assert.Equal(1, resultado.Id);
    }

    // CT-U02 – Buscar usuário inexistente retorna null
    [Fact]
    public void BuscarUsuario_IdInexistente_RetornaNull()
    {
        var context = CriarContexto("CT_U02");
        var repo = new UsuarioRepository(context);

        var resultado = repo.BuscarUsuario(99);

        Assert.Null(resultado);
    }

    // CT-U03 – Cadastrar usuário com CPF único
    [Fact]
    public void CadastrarUsuario_CpfUnico_RetornaUsuario()
    {
        var context = CriarContexto("CT_U03");
        var repo = new UsuarioRepository(context);
        var usuario = new Usuario
        {
            Nome = "Novo", Cpf = "12345678900",
            Email = "novo@email.com", Telefone = "31999999999",
            Dt_Nascimento = new DateOnly(2000, 1, 1),
            Tipo_Usuario = "Instrutor", SenhaHash = "hash"
        };

        var resultado = repo.CadastrarUsuario(usuario);

        Assert.NotNull(resultado);
        Assert.Equal(1, context.Usuarios.Count());
    }

    // CT-U04 – Cadastrar usuário com CPF duplicado retorna null
    [Fact]
    public void CadastrarUsuario_CpfDuplicado_RetornaNull()
    {
        var context = CriarContexto("CT_U04");
        context.Usuarios.Add(new Usuario
        {
            Nome = "Primeiro", Cpf = "12345678900",
            Email = "p@email.com", Telefone = "31999999999",
            Dt_Nascimento = new DateOnly(2000, 1, 1),
            Tipo_Usuario = "Instrutor", SenhaHash = "hash"
        });
        context.SaveChanges();

        var repo = new UsuarioRepository(context);
        var segundo = new Usuario
        {
            Nome = "Segundo", Cpf = "12345678900",
            Email = "s@email.com", Telefone = "31988888888",
            Dt_Nascimento = new DateOnly(1999, 5, 10),
            Tipo_Usuario = "Administrador", SenhaHash = "hash2"
        };

        var resultado = repo.CadastrarUsuario(segundo);

        Assert.Null(resultado);
        Assert.Equal(1, context.Usuarios.Count());
    }

    // CT-U05 – BuscarInstrutores retorna apenas tipo "Instrutor"
    [Fact]
    public void BuscarInstrutores_RetornaApenasInstrutores()
    {
        var context = CriarContexto("CT_U05");
        context.Usuarios.AddRange(
            new Usuario
            {
                Nome = "Instrutor A", Cpf = "11111111111",
                Email = "a@email.com", Telefone = "31911111111",
                Dt_Nascimento = new DateOnly(1990, 1, 1),
                Tipo_Usuario = "Instrutor", SenhaHash = "hash"
            },
            new Usuario
            {
                Nome = "Admin B", Cpf = "22222222222",
                Email = "b@email.com", Telefone = "31922222222",
                Dt_Nascimento = new DateOnly(1985, 3, 15),
                Tipo_Usuario = "Administrador", SenhaHash = "hash"
            }
        );
        context.SaveChanges();

        var repo = new UsuarioRepository(context);
        var resultado = repo.BuscarInstrutores().ToList();

        Assert.Single(resultado);
        Assert.Equal("Instrutor", resultado[0].Tipo_Usuario);
    }
}