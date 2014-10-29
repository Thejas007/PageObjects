using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAutomation;
using NUnit.Framework;

namespace PageObjects.Tests
{
		[TestFixture]
		public class SetUpTestWithPage
		{
			private string baseUrl;
			private StartUpPage startUpPage;

			public SetUpTestWithPage()
			{
				startUpPage = new StartUpPage(SeleniumWebDriver.Browser.Chrome);
				baseUrl = "http://127.0.0.1/";
			}


			[Test]
			public void OpenProjectWebPage()
			{
				startUpPage.OpenUrl(baseUrl + "Search/Index.html");
				startUpPage.EnterSurName("john");
				startUpPage.ClickSubmit();
				startUpPage.VerifyResult();

			}

			[TestFixtureTearDown]
			public void EndTest()
			{
				startUpPage.Close();

			}
		}
	
}
