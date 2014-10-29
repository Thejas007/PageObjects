using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class PageBase
    {
       protected FluentAutomation.Interfaces.INativeActionSyntaxProvider I { get; private set; }

		protected FluentTest FluentTest;
		public PageBase(SeleniumWebDriver.Browser browser)
		{
			SeleniumWebDriver.Bootstrap(browser);
			FluentTest = new FluentTest();
			I = FluentTest.I;

		}
		public PageBase()
		{
			SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
			FluentTest = new FluentTest();
			I = FluentTest.I;

		}

		/** Open  */
		public void OpenUrl(string url)
		{
			I.Open(url);
            I.Wait(5);
		}

		public void Close()
		{
			I.Dispose();

		}

    }
}
