using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace BlackBelt.Tests;

public class NovosTestesFuncionais : IDisposable
{
    private readonly IWebDriver driver;
    private readonly WebDriverWait wait;
    private const string Url = "http://localhost:5071";

    public NovosTestesFuncionais()
    {
        driver = new ChromeDriver();
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    private void FazerLogin()
    {
        driver.Navigate().GoToUrl($"{Url}/Login/Index");

        wait.Until(d => d.FindElement(By.CssSelector("input[name='cpf'], input[name='Cpf']"))).SendKeys("admin");
        driver.FindElement(By.CssSelector("input[name='senha'], input[name='Senha'], input[type='password']")).SendKeys("admin");
        driver.FindElement(By.CssSelector("button[type='submit'], input[type='submit']")).Click();

        wait.Until(d => d.Url.Contains("/Home") || d.PageSource.Contains("Admin Teste"));
    }

    [Fact]
    public void FT06_LoginInvalido_DeveMostrarErro()
    {
        driver.Navigate().GoToUrl($"{Url}/Login/Index");

        wait.Until(d => d.FindElement(By.CssSelector("input[name='cpf'], input[name='Cpf']"))).SendKeys("usuarioerrado");
        driver.FindElement(By.CssSelector("input[name='senha'], input[name='Senha'], input[type='password']")).SendKeys("senhaerrada");
        driver.FindElement(By.CssSelector("button[type='submit'], input[type='submit']")).Click();

        wait.Until(d => d.PageSource.Contains("Usuário ou senha inválidos"));
        Assert.Contains("Usuário ou senha inválidos", driver.PageSource);
    }

    [Fact]
    public void FT07_AbrirTelaAlunos_DeveCarregarPagina()
    {
        FazerLogin();

        driver.Navigate().GoToUrl($"{Url}/Alunos/Index");

        wait.Until(d => d.PageSource.Contains("Aluno") || d.PageSource.Contains("Alunos"));
        Assert.True(driver.PageSource.Contains("Aluno") || driver.PageSource.Contains("Alunos"));
    }

    [Fact]
    public void FT08_AbrirTelaUsuarios_DeveCarregarPagina()
    {
        FazerLogin();

        driver.Navigate().GoToUrl($"{Url}/Usuarios/Index");

        wait.Until(d => d.PageSource.Contains("Usuário") || d.PageSource.Contains("Usuarios"));
        Assert.True(driver.PageSource.Contains("Usuário") || driver.PageSource.Contains("Usuario"));
    }

    [Fact]
    public void FT09_AbrirTelaTurmas_DeveCarregarPagina()
    {
        FazerLogin();

        driver.Navigate().GoToUrl($"{Url}/Turmas/Index");

        wait.Until(d => d.PageSource.Contains("Turma") || d.PageSource.Contains("Turmas"));
        Assert.True(driver.PageSource.Contains("Turma") || driver.PageSource.Contains("Turmas"));
    }

    [Fact]
    public void FT10_AbrirTelaFrequencia_DeveCarregarPagina()
    {
        FazerLogin();

        driver.Navigate().GoToUrl($"{Url}/RegistrarPresenca/Index");

        wait.Until(d => d.PageSource.Contains("Presença") || d.PageSource.Contains("Frequência"));
        Assert.True(driver.PageSource.Contains("Presença") || driver.PageSource.Contains("Frequência"));
    }

    public void Dispose()
    {
        driver.Quit();
    }
}