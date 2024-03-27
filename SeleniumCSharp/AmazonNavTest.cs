using System;
using System.Net;
using NUnit.Fraework;
using OpenQA.Selenium.Chrome;

namespace AmazonWebsiteTest
{
	[TestFixture]
	public class AmazonWebsiteNavTest
	{
		private iWebDriver driver;

		[Setup]
		public void Setup()
		{
			// setup chrome webdriver
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}
		[Test]
		public void ClickOnCareersPage()
		{
			driver.Navigate().GoToUrl("https://www.amazon.com");

			//click on careers page link
			IWebElement careersLink = driver.FindElement(By.CssSelector("a[href*='/careers']"));
			careersLink.Click();

			// assert that the current URL contains the career page
			Assert.That(driver.Url, Does.Contain("careers"));

		}

		[TearDown]
		public void TearDown()
		{
			// close browser
			driver.Quit();
		}
	}


}

