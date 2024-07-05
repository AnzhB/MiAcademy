using Co.miacademy.Pages;
using Co.miacademy.Util;
using OpenQA.Selenium;

namespace Co.miacademy
{
    public class HomePage : BasePage
    {
        private static readonly string BASE_URL = TestDataReader.GetTestData("url");
        private readonly string miaPrepOnlineHighSchoolLink = "//div[contains(@class, 'mia-announcementContainer')]//span/a";

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public void ClickMiaPrepOnlineHighSchoolLink()
        {
            driver.FindElement(By.XPath(miaPrepOnlineHighSchoolLink)).Click();
        }
    }
}