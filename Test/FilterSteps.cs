using Automation_E2E_Amazon.PageObjects;
using TechTalk.SpecFlow;

namespace Automation_E2E_Amazon
{
    [Binding]
    public class FilterSteps : FilterPage
    {
        [Given(@"I am in the first page")]
        public void GivenIAmInTheFirstPage()
        {
            GoToInitialPage();
        }
        
        [Given(@"I tipe in the filter ""(.*)""")]
        public void GivenITipeInTheFilter(string search)
        {
            FilterSearch(search);
        }
        
        [When(@"I press the ""(.*)""")]
        public void WhenIPressThe(string button)
        {
            ClickInButton(button);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string search)
        {
            IsFilterWorking(search);
        }

        [AfterFeature("EndDrive")]
        static public void EndDrive()
        {
            ClearCookie();
            KillDriver();
        }
    }
}
