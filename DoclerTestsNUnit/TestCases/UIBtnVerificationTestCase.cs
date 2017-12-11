using System;
using DoclerTestsNUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace DoclerTestsNUnit
{
	public class UIBtnVerificationTestCase:WebDriverRun
	{	
		 /*
    1. Open Home Page (in Before Method)
    2. Click on UI Testing icon
    3. Check that URL correspond to expected
    4. Check that Logo and Title are displayed and correspond to expected
    */
		
		[Test]
		public void clickOnUIBtnCheckURL()
		{	
			HomePage homePage = new HomePage(driver);
			homePage.clickOnUIBtnCheckURL(driver);
			homePage.verifyPageTitle(driver);
			homePage.verifyLogoIsPresent(driver);
		}
		}
	}

