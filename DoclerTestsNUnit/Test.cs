using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DoclerTestsNUnit
{
	//[TestFixture()]
	public class Test
	{
		//[Test()]
		public void TestCase()
		{
			//IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), DesiredCapabilities.Chrome());
			//driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
			////TestSuiteDoclerHolding.Waiter.Waiter wait = new TestSuiteDoclerHolding.Waiter.Waiter();
			//IWebElement uiTestingBtn = driver.FindElement(By.XPath(".//*[@id = 'form']"));
			////wait.waitForElementToShowUp(uiTestingBtn, driver);
			//uiTestingBtn.Click();
			//String currentURL = driver.Url;
			//Assert.AreEqual(currentURL, "http://uitest.duodecadits.com/form.html");
		}
	}
}
