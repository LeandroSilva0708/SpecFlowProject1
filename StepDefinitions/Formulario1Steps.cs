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
            _driver = WebDriverSupport.GetWebDriver();
        }

        [Given(@"que eu estou na página do formulário 1")]
        public void DadoQueEuEstouNaPaginaDoFormulario1()
        {
            _driver.Navigate().GoToUrl("https://imagens.amcom.com.br/HTML/testeQA_1_1.html");
        }

        [When(@"eu preencho o campo Nome com ""(.*)""")]
        public void QuandoEuPreenchoOCampoNomeCom(string nome)
        {
            _driver.FindElement(By.Id("nome")).SendKeys(nome);
        }

        [When(@"eu preencho o campo Sobrenome com ""(.*)""")]
        public void QuandoEuPreenchoOCampoSobrenomeCom(string sobrenome)
        {
            _driver.FindElement(By.Id("sobrenome")).SendKeys(sobrenome);
        }

        [When(@"eu preencho o campo Telefone com ""(.*)""")]
        public void QuandoEuPreenchoOCampoTelefoneCom(string telefone)
        {
            _driver.FindElement(By.Id("telefone")).SendKeys(telefone);
        }

        [When(@"eu clico no botão Enviar")]
        public void QuandoEuClicoNoBotaoEnviar()
        {
            _driver.FindElement(By.Id("enviar")).Click();
        }

        [Then(@"o formulário deve ser enviado com sucesso")]
        public void EntaoOFormularioDeveSerEnviadoComSucesso()
        {
            Assert.IsTrue(_driver.FindElement(By.Id("mensagemSucesso")).Displayed);
        }
    }
}
