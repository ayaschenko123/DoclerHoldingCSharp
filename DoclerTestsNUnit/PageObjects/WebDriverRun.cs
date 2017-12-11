using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DoclerTestsNUnit
{
	public class WebDriverRun
	{	
		public IWebDriver driver;


		[SetUp]
		public void RunBr()
		{
			this.driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), DesiredCapabilities.Chrome());
			driver.Manage().Window.Size = new System.Drawing.Size (1920, 1080);
			driver.Navigate().GoToUrl("http://uitest.duodecadits.com");
		}

		[TearDown]
		public void CloseBrowser()
		{
			this.driver.Close();
		}
	}
}
