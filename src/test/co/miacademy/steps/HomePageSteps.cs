using TechTalk.SpecFlow;

namespace Co.miacademy.Steps
{
    [Binding]
    public class HomePageSteps
    {
        private readonly HomePage homePage;

        public HomePageSteps()
        {
            homePage = new HomePage(); 
        }

        [Given("Open Main Page")]
        public void OpenMainPage()
        {
            homePage.OpenPage();
        }

        [When("Click on Mia Prep Online High School Link")]
        public void ClickOnMiaPrepOnlineHighSchoolLink()
        {
            homePage.ClickMiaPrepOnlineHighSchoolLink();
        }
    }
}
