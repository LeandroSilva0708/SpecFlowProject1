using SpecFlowProject1.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Formulario3Steps
    {
        private readonly IWebDriver _driver;

        public Formulario3Steps()
        {
            _driver = WebDriverSupport.GetWebDriver();
        }

        [Given(@"que eu estou na página do formulário 3")]
        public void DadoQueEuEstouNaPaginaDoFormulario3()
        {
            _driver.Navigate().GoToUrl("https://imagens.amcom.com.br/HTML/testeQA_1_1.html");
        }

        [When(@"eu clico no botão Ver horario")]
        public void QuandoEuClicoNoBotaoVerHorario()
        {
            _driver.FindElement(By.Id("verHorario")).Click();
        }

        [Then(@"a mensagem ""(.*)"" deve ser exibida")]
        public void EntaoAMensagemDeveSerExibida(string mensagem)
        {
            var mensagemElemento = _driver.FindElement(By.Id("mensagemHorario"));
            Assert.AreEqual(mensagem, mensagemElemento.Text);
        }
    }
}



