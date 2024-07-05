using Co.miacademy.Model.Enums;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Co.miacademy.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        private static IWebDriver driver;
        private static WebDriverManager webDriverManager;

        [BeforeScenario]
        public void setupDriver()
        {
            if (driver == null)
            {
                webDriverManager = new WebDriverManager();
                driver = webDriverManager.CreateWebDriver(WebDriverType.CHROME);
                driver.Manage().Window.Maximize();
            }
        }

        [AfterScenario]
        public void tearDown(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null && driver != null)
            {
                var filePath = ScreenshotHelper.TakeScreenshot(driver);
                scenarioContext.Add("screenshot", filePath);
            }
            driver.Quit();
        }

        public static IWebDriver GetWebDriver()
        {
            return driver;
        }
    }
}