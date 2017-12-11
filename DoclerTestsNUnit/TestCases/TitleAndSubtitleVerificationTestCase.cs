using System;
using NUnit.Framework;

namespace DoclerTestsNUnit
{
	public class TitleAndSubtitleVerificationTestCase: WebDriverRun
	{	
		    /*
    1. Open Home Page (in Before Method)
    2. Check that title text correspond to expected
    */
		[Test]
		public void clickOnHomeButtonAndCheckTitles()
		{
			HomePage homePage = new HomePage(driver);
			homePage.checkTitleCorrespondToExpected(driver);
			homePage.checkSubTitleCorrespondToExpected(driver);
		}
	}
}
