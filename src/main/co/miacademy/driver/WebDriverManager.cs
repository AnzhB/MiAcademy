using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using Co.miacademy.Model.Enums;
using Co.miacademy.Util;
using OpenQA.Selenium.Remote;

namespace Co.miacademy
{
    public class WebDriverManager
    {
        private IWebDriver driver;

        public IWebDriver CreateWebDriver(WebDriverType webDriverType)
        {
            if (driver == null)
            {
                switch (webDriverType)
                {
                    case WebDriverType.CHROME:
                        driver = new ChromeDriver();
                        break;
                    case WebDriverType.FIREFOX:
                        driver = new FirefoxDriver();
                        break;
                    case WebDriverType.SAFARI:
                        driver = new SafariDriver();
                        break;
                    case WebDriverType.REMOTE:
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.BrowserVersion = "latest"; 
                        driver = new RemoteWebDriver(new Uri(TestDataReader.GetTestData("grid.url")), chromeOptions.ToCapabilities());
                        break;
                    case WebDriverType.SAUCELABS_CHROME:
                        ChromeOptions sauceOptions = new ChromeOptions();
                        sauceOptions.PlatformName = "macOS 12";
                        sauceOptions.BrowserVersion = "75";
                        Dictionary<string, object> sauceCaps = new Dictionary<string, object>
                        {
                            { "name", "Remote test" }
                        };
                        sauceOptions.AddAdditionalOption("sauce:options", sauceCaps);
                        try
                        {
                            driver = new RemoteWebDriver(new Uri(TestDataReader.GetTestData("saucelabs.url")), sauceOptions);
                        }
                        catch (UriFormatException e)
                        {
                            throw new WebDriverException("Invalid Sauce Labs URL", e);
                        }
                        break;
                    default:
                        throw new ArgumentException("Unsupported browser: " + webDriverType);
                }
            }
            return driver;
        }

        public void QuitWebDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}