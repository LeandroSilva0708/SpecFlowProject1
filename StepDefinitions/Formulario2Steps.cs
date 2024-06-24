using SpecFlowProject1.Drivers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Formulario2Steps
    {
        private readonly IWebDriver _driver;

        public Formulario2Steps()
        {
            _driver = WebDriverSupport.GetWebDriver();
        }

        [Given(@"que eu estou na página do formulário 2")]
        public void DadoQueEuEstouNaPaginaDoFormulario2()
        {
            _driver.Navigate().GoToUrl("https://imagens.amcom.com.br/HTML/testeQA_1_1.html");
        }

        [When(@"eu seleciono a cor ""(.*)""")]
        public void QuandoEuSelecionoACor(string cor)
        {
            var dropdown = _driver.FindElement(By.Id("cor"));
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(cor);
        }

        [Then(@"a cor ""(.*)"" deve estar selecionada")]
        public void EntaoACorDeveEstarSelecionada(string cor)
        {
            var dropdown = _driver.FindElement(By.Id("cor"));
            var selectElement = new SelectElement(dropdown);
            Assert.AreEqual(cor, selectElement.SelectedOption.Text);
        }
    }
}

