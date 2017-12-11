using System;
using NUnit.Framework;

namespace DoclerTestsNUnit
{
	public class HeaderBtnsCheckLinkAndStatusTestCase : WebDriverRun
	{	
		  /*
    1. Open Home Page (in Before Method)
    2. Click on one of Header icon 
    3. Check that link correspond to expected and icon status is active
    */

		[Test]
		public void clickOnElementAndCheckStatusAndLink()
		{
			HomePage homePage = new HomePage(driver);
			homePage.clickOnElementAndCheckStatusAndLink(driver);
		}
	}
}
