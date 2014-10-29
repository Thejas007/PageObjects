using FluentAutomation;
namespace PageObjects.Tests.Pages
{
class StartUpPage : PageBase.PageBase
	{
		 
		public StartUpPage(SeleniumWebDriver.Browser driver)
			: base(driver)
		{
			
		}
		
		public void EnterSurName(string surName)
		{
			I.Enter(surName).In("#surname");
		}
	
		
		public void ClickSubmit()
		{
			I.Click("#generalSearch");
			
		}
		
		public void VerifyResult()
		{
						I.Expect.Count(48).Of("li.well.vcard.general.ng-scope");
		}

	}
}
