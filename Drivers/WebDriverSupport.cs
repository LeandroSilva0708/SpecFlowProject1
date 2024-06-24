using SpecFlowProject1.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Formulario1Steps
    {
        private readonly IWebDriver _driver;

        public Formulario1Steps()
        {
            _driver = WebDriverSupport.GetWebDriver(); // Inicialize _driver aqui
        }

        [Given(@"que eu estou na página do formulário 1")]
        public void DadoQueEuEstouNaPaginaDoFormulario1()
        {
            _driver.Navigate().GoToUrl("https://imagens.amcom.com.br/HTML/testeQA_1_1.html");
        }

        // Outros métodos...
    }
}

