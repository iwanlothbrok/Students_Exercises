using NUnit.Framework;
using OpenQA.Selenium.Appium;
using System;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using NUnit.Framework.Constraints;

namespace AppiumMobileTests
{
	public class ContactBookTests
	{
		private const string AppiumServerUri = "http://[::1]:4723/wd/hub";
		private const string ContactBookAppPath = @"C:\Users\JupiterSoft\Documents\GitHub\Students\Appium\Android\12.Appium-Mobile-Testing-Resources\contactbook-androidclient.apk"; //CHECK IF ITS RIGHT
		private const string ApiServiceUrl = "https://contactbook.nakov.repl.co/api";
		private AndroidDriver<AndroidElement> driver;
		private WebDriverWait wait;
		[SetUp]
		public void Setup()
		{
			AppiumOptions options = new AppiumOptions() { PlatformName = "Android" };
			options.AddAdditionalCapability("app", ContactBookAppPath);
			this.driver = new AndroidDriver<AndroidElement>(new Uri(AppiumServerUri), options);

			this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
		}

		[Test]
		public void Test_AndroidApp_SearchSteveContacts()
		{
			AndroidElement editTextApiUri = this.driver
							.FindElementById("contactbook.androidclient:id/editTextApiUrl");


			editTextApiUri.Clear();
			editTextApiUri.SendKeys(ApiServiceUrl);


			AndroidElement buttonElement = this.driver
											   .FindElementById("contactbook.androidclient:id/buttonConnect");
			buttonElement.Click();


			AndroidElement editTextKeyword = this.driver.FindElementById("contactbook.androidclient:id/editTextKeyword");
			editTextKeyword.Clear();
			editTextKeyword.SendKeys("Steve");
			

			AndroidElement buttonSearch= this.driver.FindElementById("contactbook.androidclient:id/buttonSearch");
			buttonSearch.Click();
			

			AndroidElement textViewResult= this.driver.FindElementById("contactbook.androidclient:id/textViewSearchResult");
			this.wait.Until(t => textViewResult.Text != "");
			string result = textViewResult.Text;
			Assert.That(result.Contains("Contacts found: 1"));


			AndroidElement firstNameResult = this.driver.FindElementById("contactbook.androidclient:id/textViewFirstName");
			Assert.AreEqual("Steve", firstNameResult.Text);
			

			AndroidElement lastNameResult = this.driver.FindElementById("contactbook.androidclient:id/textViewLastName");
			Assert.AreEqual("Jobs", lastNameResult.Text);
		}

		[Test]
		public void Test_AndroidApp_SearchPeshoContacts()
		{
			AndroidElement editTextApiUri = this.driver
						.FindElementById("contactbook.androidclient:id/editTextApiUrl");


			editTextApiUri.Clear();
			editTextApiUri.SendKeys(ApiServiceUrl);


			AndroidElement buttonElement = this.driver
											   .FindElementById("contactbook.androidclient:id/buttonConnect");
			buttonElement.Click();


			AndroidElement editTextKeyword = this.driver.FindElementById("contactbook.androidclient:id/editTextKeyword");
			editTextKeyword.Clear();
			editTextKeyword.SendKeys("pesho");


			AndroidElement buttonSearch = this.driver.FindElementById("contactbook.androidclient:id/buttonSearch");
			buttonSearch.Click();


			AndroidElement textViewResult = this.driver.FindElementById("contactbook.androidclient:id/textViewSearchResult");
			this.wait.Until(t => textViewResult.Text != "");
			string result = textViewResult.Text;
			Assert.That(result.Contains("Contacts found: 0"));
		}

		[Test]
		public void Test_AndroidApp_SearchContactsWithE()
		{
			AndroidElement editTextApiUri = this.driver
						.FindElementById("contactbook.androidclient:id/editTextApiUrl");


			editTextApiUri.Clear();
			editTextApiUri.SendKeys(ApiServiceUrl);


			AndroidElement buttonElement = this.driver
											   .FindElementById("contactbook.androidclient:id/buttonConnect");
			buttonElement.Click();


			AndroidElement editTextKeyword = this.driver.FindElementById("contactbook.androidclient:id/editTextKeyword");
			editTextKeyword.Clear();
			editTextKeyword.SendKeys("e");


			AndroidElement buttonSearch = this.driver.FindElementById("contactbook.androidclient:id/buttonSearch");
			buttonSearch.Click();


			AndroidElement textViewResult = this.driver.FindElementById("contactbook.androidclient:id/textViewSearchResult");
			this.wait.Until(t => textViewResult.Text != "");
			string result = textViewResult.Text;
			Assert.That(result.Contains("Contacts found: 3"));
		}

		[TearDown]
		public void TearDown()
		{
			this.driver.Quit();
		}
	}
}
