using System;
using NUnit.Framework;

namespace DoclerTestsNUnit
{
	public class FormVerificationTestCase : WebDriverRun
	{	
		/*
    1. Open Home Page (in Before Method)
    2. Click on Form icon
    3. Check that all needed form alements are displayed
    4. Open Home Page 
    5. Click on Form icon
    6. Enter name into name field and click on 'Go' button
    7. Check that thank you texts correspond to expected
    8. Check that Logo and Title are displayed and correspond to expected
    */
		[Test]
		public void checkFormElementsAreDisplayed([Values("John", "Sophia", "Charlie", "Emily")] String name)
		{
			HomePage homePage = new HomePage(driver);
			homePage.checkFormElementsArePresent(driver);
			homePage.formSubmissionVerification(driver, name);
			homePage.verifyPageTitle(driver);
			homePage.verifyLogoIsPresent(driver);
		}
	}
}
