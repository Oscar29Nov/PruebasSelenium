using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework.Drivers
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver() 
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return new ChromeDriver(options);

        }
        
    }
}
