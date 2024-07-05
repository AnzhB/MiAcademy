using Co.miacademy.Pages;
using OpenQA.Selenium;

namespace Co.miacademy
{
    public class FormPage: BasePage
    {
        private readonly string formUrl = "https://forms.zohopublic.com";
        private readonly string parentSectionId = "Section-li";
        private readonly string studentSectionId = "Section3-li";
        private readonly string sectionTemplate = "//li[@id='{0}']/h2[@class='advLabelName']/div/b";
        private readonly string fullNameTemplate = "//*[@id='Name-li']/div[2]/div/span[{0}]/input";
        private readonly string email = "//*[@id='Email-arialabel']";
        private readonly string phone = "//*[@id='PhoneNumber']";
        private readonly string addSecondParentDropdown = "//div[@class='form_selectBox']/select[@id='Dropdown-arialabel']/following-sibling::span//span[*][@role='presentation']";
        private readonly string addSecondParentOptionTemplate = "//li[contains(@class, 'select2-results__option') and text()= '{0}']";
        private readonly string startDate = "//*[@id='Date-date']";
        private readonly string nextButton = "//div[@class = 'inlineBlock nextAlign']/button[contains(@aria-label,'2 out of 3')]";

        public void VerifyApplicationFormSectionIsOpened(string expectedSection)
        {
            Assert.Contains(formUrl, driver.Url.ToLower());
            string sectionId = expectedSection == "Parent Information" ? parentSectionId  : studentSectionId;
            var actualSectionName = driver.FindElement(By.XPath(string.Format(sectionTemplate, sectionId))).Text;
            Assert.Equal(expectedSection, actualSectionName);
        }

        public void FillInParentInformationWithData(string inputFirstName, string inputLastName, string inputEmail, string inputPhone, string inputAddSecondParent, string inputStartDate)
        {
            driver.FindElement(By.XPath(string.Format(fullNameTemplate, 1))).SendKeys(inputFirstName);
            driver.FindElement(By.XPath(string.Format(fullNameTemplate, 2))).SendKeys(inputLastName);
            driver.FindElement(By.XPath(email)).SendKeys(inputEmail);
            driver.FindElement(By.XPath(phone)).SendKeys(inputPhone);
            driver.FindElement(By.XPath(addSecondParentDropdown)).Click();
            driver.FindElement(By.XPath(string.Format(addSecondParentOptionTemplate, inputAddSecondParent))).Click();
            driver.FindElement(By.XPath(startDate)).SendKeys(inputStartDate);
        }

        public void ClickNextButton()
        {
            driver.FindElement(By.XPath(nextButton)).Click();
        }

    }
}