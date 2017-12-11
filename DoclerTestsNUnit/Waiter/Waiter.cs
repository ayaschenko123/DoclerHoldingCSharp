using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DoclerTestsNUnit
{

	public class Waiter
	{
		public void waitForElementToBeClickable(IWebElement elementLocator, IWebDriver driver)
		{
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
			wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
		}
	}
}