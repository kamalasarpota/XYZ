using System;
using TechTalk.SpecFlow;
using BBCTest.Setup;
using BBCTest.Pages;
using OpenQA.Selenium;

namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "HeaderLinks")]
    public class HeaderLinksSteps: SetUp
    {
        public IWebDriver Browser;

           [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {

        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOnNews()
        {

        }
        
        [Then(@"I see the (.*) pages")]
        public void ThenISeeTheNewsPages()
        {

        }
    }
}
