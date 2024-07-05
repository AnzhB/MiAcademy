using TechTalk.SpecFlow;

namespace Co.miacademy.Steps
{
    [Binding]
    public class MiaPrepPageSteps
    {
        private readonly MiaPrepPage miaPrepPage;

        public MiaPrepPageSteps()
        {
            miaPrepPage = new MiaPrepPage();
        }

        [Then("Verify Mia Prep Online High School Page is opened")]
        public void VerifyMiaPrepOnlineHighSchoolPageIsOpened()
        {
            miaPrepPage.VerifyMiaPrepOnlineHighSchoolPageIsOpened();
        }

        [When("Click on Apply to Our School Button")]
        public void ClickOnApplyToOurSchoolButton()
        {
            miaPrepPage.ClickApplyToOurSchoolButton();
        }
    }
}
