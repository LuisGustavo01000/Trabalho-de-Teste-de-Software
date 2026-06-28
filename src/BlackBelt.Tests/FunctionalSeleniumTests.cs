using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BlackBelt.Tests;

public class FunctionalSeleniumTests : IDisposable
{
    private readonly IWebDriver _driver;
    private readonly WebDriverWait _wait;
    private readonly string _baseUrl;

    public FunctionalSeleniumTests()
    {
        _baseUrl = Environment.GetEnvironmentVariable("BLACKBELT_BASE_URL") ?? "http://localhost:5279";

        var options = new ChromeOptions();
        //options.AddArgument("--headless=new");
        options.AddArgument("--window-size=1920,1080");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");

        _driver = new ChromeDriver(options);
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
    }

    [Fact(DisplayName = "Caso de Teste CTF01 - Carregar tela de login")]
    public void FT01_LoginPage_ShouldLoadWithExpectedElements()
    {
        _driver.Navigate().GoToUrl($"{_baseUrl}/Login/Index");

        _wait.Until(d => d.FindElement(By.Id("cpfInput")));

        Assert.Contains("Login", _driver.Title, StringComparison.OrdinalIgnoreCase);
        Assert.NotNull(_driver.FindElement(By.Id("cpfInput")));
        Assert.NotNull(_driver.FindElement(By.CssSelector("input[type='password']")));
        Assert.NotNull(_driver.FindElement(By.CssSelector("button[type='submit']")));
    }

    [Fact(DisplayName = "Caso de Teste CTF02 - Acesso pela rota inicial")]
    public void FT02_DefaultRoute_ShouldOpenLoginPage()
    {
        _driver.Navigate().GoToUrl(_baseUrl);

        _wait.Until(d => d.FindElement(By.Id("cpfInput")));

        Assert.True(
            _driver.Url.EndsWith("/", StringComparison.OrdinalIgnoreCase) ||
            _driver.Url.Contains("/Login/Index", StringComparison.OrdinalIgnoreCase),
            $"URL inesperada para tela de login: {_driver.Url}");
        Assert.Contains("BLACK BELT", _driver.PageSource, StringComparison.OrdinalIgnoreCase);
    }

    [Fact(DisplayName = "Caso de Teste CTF03 - Bloqueio anonimo em Usuarios")]
    public void FT03_AnonymousAccess_UsuariosIndex_ShouldRedirectToLogin()
    {
        _driver.Navigate().GoToUrl($"{_baseUrl}/Usuarios/Index");

        _wait.Until(d => d.Url.Contains("/Login/Index", StringComparison.OrdinalIgnoreCase));

        Assert.Contains("/Login/Index", _driver.Url, StringComparison.OrdinalIgnoreCase);
        Assert.NotNull(_driver.FindElement(By.Id("cpfInput")));
    }

    [Fact(DisplayName = "Caso de Teste CTF04 - Bloqueio anonimo em Turmas")]
    public void FT04_AnonymousAccess_TurmasIndex_ShouldRedirectToLogin()
    {
        _driver.Navigate().GoToUrl($"{_baseUrl}/Turmas/Index");

        _wait.Until(d => d.Url.Contains("/Login/Index", StringComparison.OrdinalIgnoreCase));

        Assert.Contains("/Login/Index", _driver.Url, StringComparison.OrdinalIgnoreCase);
        Assert.NotNull(_driver.FindElement(By.Id("cpfInput")));
    }

    [Fact(DisplayName = "Caso de Teste CTF05 - Bloqueio anonimo em Registro de Presenca")]
    public void FT05_AnonymousAccess_RegistrarPresencaIndex_ShouldRedirectToLogin()
    {
        _driver.Navigate().GoToUrl($"{_baseUrl}/RegistrarPresenca/Index");

        _wait.Until(d => d.Url.Contains("/Login/Index", StringComparison.OrdinalIgnoreCase));

        Assert.Contains("/Login/Index", _driver.Url, StringComparison.OrdinalIgnoreCase);
        Assert.NotNull(_driver.FindElement(By.Id("cpfInput")));
    }

    public void Dispose()
    {
        _driver.Quit();
        _driver.Dispose();
        GC.SuppressFinalize(this);
    }
}
