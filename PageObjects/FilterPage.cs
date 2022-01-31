using Automation_E2E_Amazon.Base;

namespace Automation_E2E_Amazon.PageObjects
{
    public class FilterPage: BasePage
    {
        public void GoToInitialPage()
        {
            GoToUrl(UrlBase);
        }

        public void FilterSearch(string search)
        {
            ClearById("twotabsearchtextbox");
            SendKeysById("twotabsearchtextbox", search);
        }

        public void ClickInButton(string button)
        {
            if (button.Equals("search icon"))
                ClickById("nav-search-submit-button");        
        }

        public bool IsFilterWorking(string search)
        {
            return VerifyTextExistsInsideAPath("//*[@id='search']/div[1]", search);
        }
    }
}
