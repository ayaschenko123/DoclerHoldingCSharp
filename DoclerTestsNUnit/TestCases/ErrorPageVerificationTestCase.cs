using System;
using System.Net;
using NUnit.Framework;

namespace DoclerTestsNUnit
{
	public class ErrorPageVerificationTestCase:WebDriverRun
	{	
		    /*
    1. Open Home Page (in Before Method)
    2. Click on Error icon
    3. Check '404' is mentioned in page title
     */
		[Test]
		public void clickOnErrorBtnAndCheckResponseCode()
		{
			HomePage homePage = new HomePage(driver);
			homePage.clickOnErrorBtnAndCheckResponseCodeInTitle(driver);
		}
	}
}
