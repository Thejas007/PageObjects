using FluentAutomation;
using PageObjects.Base;

namespace PageObjects.Tests
{
class StartUpPage : PageBase
	{
		 
		public StartUpPage(SeleniumWebDriver.Browser driver)
			: base(driver)
		{
			
		}
		
		public void EnterSurName(string surName)
		{
			this.I.Enter(surName).In("#surname");
		}
	
		
		public void ClickSubmit()
		{
			this.I.Click("#generalSearch");
			
		}
		
		public void VerifyResult()
		{
						this.I.Expect.Count(48).Of("li.well.vcard.general.ng-scope");
		}

	}
}
