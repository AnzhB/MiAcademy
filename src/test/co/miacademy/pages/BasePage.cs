using Co.miacademy.Hooks;
using OpenQA.Selenium;

namespace Co.miacademy.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver = SpecFlowHooks.GetWebDriver();
    }
}