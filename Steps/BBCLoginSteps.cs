using System;
using TechTalk.SpecFlow;
using BBCTest.Setup;
using OpenQA.Selenium;
using BBCTest.Pages;


namespace BBCTest.Steps
{
    [Binding]
    public class BBCLoginSteps : SetUp
    {
        public IWebDriver Browser;
        public BBCLogin login;

        [Given(@"I navigate to BBC")]
        [Scope(Tag ="BBCLogin")]

        public void GivenINavigatetoBBC()
        {
            Browser = driver;
            login = new BBCLogin(Browser);
            Browser.Navigate().GoToUrl("https://bbc.co.uk");
        }
      
        
        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            login.ClickSignIn();

        }
        
        [When(@"I login with valid user details")]
        public void WhenILoginWithValidUserDetails()
        {
            login.UserDetails();
        }
        
        [Then(@"I see login is succesful")]
        public void ThenISeeLoginIsSuccesful()
        {
            login.VerifyLogin();
        }
    }
}
