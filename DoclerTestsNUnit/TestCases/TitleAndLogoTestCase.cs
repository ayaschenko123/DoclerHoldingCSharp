using System;
using NUnit.Framework;

namespace DoclerTestsNUnit
{	
	   /*
    1. Open link from 'Links' Data Provider
    2. Check that page title correspond to ecpected
    3. Check that site logo is present on the page
    */
	public class TitleAndLogoTestCase:WebDriverRun
	{	
		[Test]
		public void clickOnHomeButtonAndCheckTitleAndLogoPresence([Values("http://uitest.duodecadits.com/form.html", "http://uitest.duodecadits.com/")] String linkToOpen)
		{
			HomePage homePage = new HomePage(driver);
			homePage.openLink(driver, linkToOpen);
			homePage.verifyPageTitle(driver);
			homePage.verifyLogoIsPresent(driver);
		}
	}
}
