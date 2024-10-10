using OpenQA.Selenium;

namespace SeleniumFramework.Pages
{
    public class GooglePage
    {
        private readonly IWebDriver driver;
        //private readonly By searchBox = By.Id("APjFqb");
        private readonly By searchBox = By.Name("q");
        private readonly By searchButton = By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']");
        private readonly By elementosH3 = By.CssSelector("h3.LC20lb.MBeuo.DKV0Md");

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Metodo navegarhacia Google
        public void NavigateToGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void EnterSearchText(string searchText) 
        {
             driver.FindElement(searchBox).SendKeys(searchText);

        }

        public void ClickSearchButton() 
        {
            driver.FindElement(searchButton).Click(); 
        }

        public bool GetContainSubstring()
        {
            return driver.FindElements(elementosH3).FirstOrDefault()?.Text.Contains("Java")?? false;
        }
    }
}
