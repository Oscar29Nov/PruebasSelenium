using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumFramework.Drivers;

namespace SeleniumFramework.Steps
{
    public class Hooks
    {
        private readonly ScenarioContext scenarioContext;
        private IWebDriver? driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = WebDriverFactory.CreateWebDriver();//usa la fábrica para crear el Webdriver
            this.scenarioContext["WebDriver"] = driver;//almacena el webdriver en el contexto del escenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit(); // Cierra Navegador
                driver.Dispose(); // Libera los recursos
            }
        }
    }
}
