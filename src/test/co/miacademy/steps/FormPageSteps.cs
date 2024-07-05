using TechTalk.SpecFlow;

namespace Co.miacademy.Steps
{
    [Binding]
    public class FormPageSteps
    {
        private readonly FormPage formPage;

        public FormPageSteps()
        {
            formPage = new FormPage();
        }

        [Then(@"Verify Application Form Section ""(.*)"" is opened")]
        public void VerifyApplicationFormSectionIsOpened(string expectedSection)
        {
            formPage.VerifyApplicationFormSectionIsOpened(expectedSection);
        }

        [When(@"Fill in Parent Information with the following data")]
        public void WhenFillInParentInformationWithTheFollowingData(Table table)
        {
            var data = table.Rows[0];
            formPage.FillInParentInformationWithData(data["FirstName"], data["LastName"], data["Email"], data["Phone"], data["AddSecondParent"], data["StartDate"]);
        }

        [When(@"Click Next Button")]
        public void ClickNextButton()
        {
            formPage.ClickNextButton();
        }

    }
}
