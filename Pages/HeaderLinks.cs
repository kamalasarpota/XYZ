using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace BBCTest.Pages
{
   public class HeaderLinks
    {
        public IWebDriver Driver;

        public HeaderLinks(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);

        }
        [FindsBy(How = How.ClassName, Using = "orb-nav-news")]
        public IWebElement NewsLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-sport")]
        public IWebElement SportLink;

        [FindsBy(How = How.ClassName, Using = "orb-nav-weather")]
        public IWebElement WeatherLink;

        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportUrl = "https://www.bbc.co.uk/sport";
        string WeatherUrl= "https://www.bbc.co.uk/weather";
    }
}
