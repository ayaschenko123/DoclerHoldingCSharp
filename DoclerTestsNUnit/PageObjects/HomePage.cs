using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DoclerTestsNUnit
{
	public class HomePage : WebDriverRun
	{
		Waiter wait = new Waiter();
		//private IWebDriver driver;
		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		//Locators

		//Home Page icon
		[FindsBy(How = How.Id, Using = "home")]
		public IWebElement homePageIcon { get; set; }

		//Site Logo banner
		[FindsBy(How = How.Id, Using = "dh_logo")]
		public IWebElement siteLogo { get; set; }

		//Form Page icon
		[FindsBy(How = How.Id, Using = "form")]
		public IWebElement formPageIcon { get; set; }

		//Error Page icon
		[FindsBy(How = How.Id, Using = "error")]
		public IWebElement errorPageIcon { get; set; }

		//UI Page icon
		[FindsBy(How = How.Id, Using = "site")]
		public IWebElement uiTestingBtn { get; set; }

		//Title container - title text
		[FindsBy(How = How.XPath, Using = ".//*[@class='ui-test']//h1")]
		public IWebElement titleContainer { get; set; }

		//Subtitle container - subtitle text
		[FindsBy(How = How.XPath, Using = ".//*[@class='ui-test']//p")]
		public IWebElement subTitleContainer { get; set; }

		//Form input - name field
		[FindsBy(How = How.Id, Using = "hello-input")]
		public IWebElement formInputField { get; set; }

		//Form submit button
		[FindsBy(How = How.Id, Using = "hello-submit")]
		public IWebElement formSubmitButton { get; set; }

		//Hello Text - appears after form submission
		[FindsBy(How = How.Id, Using = "hello-text")]
		public IWebElement submitText { get; set; }

		//Active header icon
		[FindsBy(How = How.XPath, Using = ".//*[@class = 'active']")]
		public IWebElement activeHeaderIcon { get; set; }



		//Services and Functions

		//Check Element is Present
		public bool IsElementPresent(IWebElement element)
		{
			try
			{
				bool e1 = element.Displayed;
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		//Open Home Page
		public void openHomePageLink(IWebDriver driver)
		{
			driver.Navigate().GoToUrl("http://uitest.duodecadits.com/");
		}

		//Open Link
		public void openLink(IWebDriver driver, String link)
		{
			driver.Navigate().GoToUrl(link);
		}

		//Verifying page title correspond to expected
		public void verifyPageTitle(IWebDriver driver)
		{
			String actualTitle = driver.Title;
			String expectedTitle = "UI Testing Site";
			Assert.AreEqual(expectedTitle, actualTitle);
		}

		//Verifying Logo is present on the page
		public void verifyLogoIsPresent(IWebDriver driver)
		{
			wait.waitForElementToBeClickable(siteLogo, driver);
			IsElementPresent(siteLogo);
		}

		//Click on UI Testing icon and verify user was redirected to corresponding URL and button became active
		public void clickOnUIBtnCheckURL(IWebDriver driver)
		{
			wait.waitForElementToBeClickable(siteLogo, driver);
			uiTestingBtn.Click();
			String currentURL = driver.Url;
			Assert.AreEqual(currentURL, "http://uitest.duodecadits.com/");

		}

		//Click on one of header icons and verify user was redirected to corresponding URL and button became active
		public void clickOnElementAndCheckStatusAndLink(IWebDriver driver)
		{
			wait.waitForElementToBeClickable(formPageIcon, driver);

			formPageIcon.Click();
			String currentURL = driver.Url;
			Assert.AreEqual(currentURL, "http://uitest.duodecadits.com/form.html");
			String activeStatusCheck = formPageIcon.Text;
			Assert.AreEqual(activeStatusCheck, "Form");

			homePageIcon.Click();
			String currentURLforHomePage = driver.Url;
			Assert.AreEqual(currentURLforHomePage, "http://uitest.duodecadits.com/");
			String activeStatusCheckHomeIcon = homePageIcon.Text;
			Assert.AreEqual(activeStatusCheckHomeIcon, "Home");
		}

		//Check that title text correspond to expected
		public void checkTitleCorrespondToExpected(IWebDriver driver)
		{	
			wait.waitForElementToBeClickable(titleContainer, driver);
			String title = titleContainer.Text;
			String expectedTitle = "Welcome to the Docler Holding QA Department";

			Assert.AreEqual(title, expectedTitle);
		}

		//Check that subtitle text correspond to expected
		public void checkSubTitleCorrespondToExpected(IWebDriver driver)
		{	
			wait.waitForElementToBeClickable(subTitleContainer, driver);
			String subTitle = subTitleContainer.Text;
			String expectedSubTitle = "This site is dedicated to perform some exercises and demonstrate automated web testing.";
			Assert.AreEqual(subTitle, expectedSubTitle);
		}

		//Open Form page and check form elements are present
		public void checkFormElementsArePresent(IWebDriver driver)
		{
			formPageIcon.Click();
			wait.waitForElementToBeClickable(formInputField, driver);
			IsElementPresent(formInputField);
			IsElementPresent(formSubmitButton);
		}

		//Submit for and check that thank you text correspond to expected
		public void formSubmissionVerification(IWebDriver driver, String name)
		{
			formPageIcon.Click();
			wait.waitForElementToBeClickable(formInputField, driver);
			formInputField.SendKeys(name);
			formSubmitButton.Click();
			String helloText = submitText.Text;
			String expectedHelloText = "Hello " + name + "!";
			Assert.AreEqual(helloText, expectedHelloText);
		}

		//Click on Error icon and check that 404 is in title
		public void clickOnErrorBtnAndCheckResponseCodeInTitle(IWebDriver driver)
		{
			errorPageIcon.Click();
			Assert.True(driver.Title.Contains("404"));
		}

	}
}