using System;
using TechTalk.SpecFlow;

namespace MakeMyTripProject.StepDefinitions
{
    [Binding]
    public class MMTDomesticTravelSteps : BaseClass
    {
        [Given(@"Open the Chrome browser")]
        public void GivenOpenTheChromeBrowser()
        {
            BaseClass.BrowserInitialization();
        }
        
        [Given(@"User has entered the URL")]
        public void GivenUserHasEnteredTheURL()
        {
            BaseClass.OpenURL();
        }
        
        [When(@"I Fill in From and To city")]
        public void WhenIFillInFromAndToCity()
        {
            BaseClass.EnterCities();
        }
        
        [Then(@"Close the browser")]
        public void ThenCloseTheBrowser()
        {
            BaseClass.CloseBrowser();
        }
    }
}
