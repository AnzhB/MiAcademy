using Co.miacademy.Pages;
using OpenQA.Selenium;

namespace Co.miacademy
{
    public class MiaPrepPage: BasePage
    {
        private readonly string applyToOurSchoolButtonXPath = "//div//a[text() = 'Apply to Our School']";

         public void VerifyMiaPrepOnlineHighSchoolPageIsOpened()
        {
           Assert.Contains("https://miaprep.com/online-school/", driver.Url.ToLower());
        }

        public void ClickApplyToOurSchoolButton()
        {
            driver.FindElement(By.XPath(applyToOurSchoolButtonXPath)).Click();
        }
    }
}