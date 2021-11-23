using OpenQA.Selenium;
using System;

namespace BJSSTechTestDotNet.CandidateTests.Utils
{
	public abstract class TestBase : IDisposable
	{
		private readonly LocalWebApplicationFactory factory;

		public Uri Url { get; }
		public IWebDriver driver { get; protected set; }

		public TestBase(LocalWebApplicationFactory factory)
		{
			this.factory = factory;
			Url = new Uri(this.factory.RootUri);

			driver = new BrowserFactory("chrome").Driver;

			driver.Navigate().GoToUrl(Url);
		}

		public void Dispose()
		{
			driver?.Quit();
		}
	}
}
