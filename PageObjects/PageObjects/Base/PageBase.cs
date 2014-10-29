using FluentAutomation;

namespace PageObjects.Base
{
    public class PageBase
    {
       protected FluentAutomation.Interfaces.INativeActionSyntaxProvider I { get; private set; }

		protected FluentTest FluentTest;
		public PageBase(SeleniumWebDriver.Browser browser)
		{
			SeleniumWebDriver.Bootstrap(browser);
			this.FluentTest = new FluentTest();
			this.I = this.FluentTest.I;

		}
		public PageBase()
		{
			SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
			this.FluentTest = new FluentTest();
			this.I = this.FluentTest.I;

		}

		/** Open  */
		public void OpenUrl(string url)
		{
			this.I.Open(url);
            this.I.Wait(5);
		}

		public void Close()
		{
			this.I.Dispose();

		}

    }
}
