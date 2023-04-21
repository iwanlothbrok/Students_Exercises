using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace AppiumMobileTests
{
	public class VivinoTests
	{
		private const string AppiumServerUri = "http://[::1]:4723/wd/hub";
		private const string VivinoAppPath = @"C:\Users\JupiterSoft\Desktop\App\vivino_8.18.11-8181203.apk"; //CHECK IF ITS RIGHT
		private const string VivinoAppPackage = "vivino.web.app";
		private const string VivinoAppStartupActivity = "com.sphinx_solution.activities.SplashActivity";
		private const string VivinoTestAccountEmail = "test_vivino@gmail.com";
		private const string VivinoTestAccountPassword = "p@ss987654321";
		private AndroidDriver<AndroidElement> driver;

		[OneTimeSetUp]
		public void Setup()
		{
			AppiumOptions options = new AppiumOptions() { PlatformName = "Android" };
			options.AddAdditionalCapability("app", VivinoAppPath);
			options.AddAdditionalCapability("appPackage", VivinoAppPackage);
			options.AddAdditionalCapability("appActivity", VivinoAppStartupActivity);
			this.driver = new AndroidDriver<AndroidElement>(new Uri(AppiumServerUri), options);

			this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
		}

		[Test]
		public void Test_WineSearch()
		{
			// Login
			AndroidElement linkLogin = this.driver.FindElementById("vivino.web.app:id/txthaveaccount");
			linkLogin.Click();


			AndroidElement textBoxLoginEmail = this.driver.FindElementById("vivino.web.app:id/edtEmail");
			textBoxLoginEmail.SendKeys(VivinoTestAccountEmail);


			AndroidElement textBoxLoginPassword = this.driver.FindElementById("vivino.web.app:id/edtPassword");
			textBoxLoginPassword.SendKeys(VivinoTestAccountPassword);


			AndroidElement singInElement = this.driver.FindElementById("vivino.web.app:id/action_singin");
			singInElement.Click();


			// Searching
			AndroidElement tabExplorer = this.driver.FindElementById("vivino.web.app:id/wine_explorer_tab");
			tabExplorer.Click();


			AndroidElement btnSearch = this.driver.FindElementById("vivino.web.app:id/search_vivino");
			btnSearch.Click();


			AndroidElement textBoxSearch = this.driver.FindElementById("vivino.web.app:id/editText_input");
			textBoxSearch.SendKeys("Katarzyna Reserve Red 2006");


			AndroidElement listSearch = this.driver.FindElementById("vivino.web.app:id/listviewWineListActivity");


			AppiumWebElement firstResult = listSearch.FindElementByClassName("android.widged.FrameLayout");
			firstResult.Click();


			AndroidElement elementWineName = this.driver.FindElementById("vivino.web.app:id/wine_name");
			Assert.AreEqual("Reserve Red 2006", elementWineName.Text);


			AndroidElement elementRating = this.driver.FindElementById("vivino.web.app:id/rating");
			double rating = double.Parse(elementRating.Text);
			Assert.IsTrue(1.00 <= rating && rating <= 5.00);


			AndroidElement tabsSummary = this.driver.FindElementById("vivino.web.app:id/tabs");
			AppiumWebElement tabHigh = tabsSummary.FindElementByXPath("//android.widget.TextView[1]");
			tabHigh.Click();


			AppiumWebElement highlithDesc = this.driver.FindElementById("vivino.web.app:id/highlight_description");
			Assert.AreEqual("Among top 1% of all vines in the world", highlithDesc.Text);


			AppiumWebElement tabFacts = tabsSummary.FindElementByXPath("//android.widget.TextView[2]");
			tabFacts.Click();



			AppiumWebElement wineTitle = this.driver.FindElementById("vivino.web.app:id/wine_fact_title");
			Assert.AreEqual("Grapes", wineTitle.Text);


			AppiumWebElement wineText = this.driver.FindElementById("vivino.web.app:id/wine_fact_text");
			Assert.AreEqual("Carbenet Sau", wineTitle.Text);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			this.driver.Quit();
		}
	}
}
