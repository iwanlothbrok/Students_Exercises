using System;

using NUnit.Framework;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumMobileTests
{
	public class AndroidSummatorTests
	{
		private const string AppiumServerUri = "http://[::1]:4723/wd/hub";
		private const string SummatorAppPath = @"C:\Users\JupiterSoft\Documents\GitHub\Students\Appium\Android\12.Appium-Mobile-Testing-Resources\com.example.androidappsummator.apk"; //CHECK IF ITS RIGHT
		private AndroidDriver<AndroidElement> driver;

		[OneTimeSetUp]
		public void Setup()
		{
			AppiumOptions options = new AppiumOptions() { PlatformName = "Android" };
			options.AddAdditionalCapability("app", SummatorAppPath);
			this.driver = new AndroidDriver<AndroidElement>(new Uri(AppiumServerUri), options);
		}

		[Test]
		public void Test_Android_Summator_ValidData()
		{
			//Arrange
			AndroidElement firstNumField = this.driver
										.FindElementById("com.example.androidappsummator:id/editText1");
			firstNumField.Clear();
			firstNumField.SendKeys("44");



			AndroidElement secondNumField = this.driver
									.FindElementById("com.example.androidappsummator:id/editText2");
			secondNumField.Clear();
			secondNumField.SendKeys("55");

			//Act
			AndroidElement calcButton = this.driver
										.FindElementById("com.example.androidappsummator:id/buttonCalcSum");

			calcButton.Click();

			//Assert
			AndroidElement resultField = this.driver
									.FindElementById("com.example.androidappsummator:id/editTextSum");

			Assert.AreEqual("99", resultField.Text);
		}


		[Test]
		public void Test_Android_Summator_InvalidData()
		{
			//Arrange
			AndroidElement firstNumField = this.driver
										.FindElementById("com.example.androidappsummator:id/editText1");
			firstNumField.Clear();
			firstNumField.SendKeys("44");



			AndroidElement secondNumField = this.driver
									.FindElementById("com.example.androidappsummator:id/editText2");
			secondNumField.Clear();
			secondNumField.SendKeys(".");

			//Act
			AndroidElement calcButton = this.driver
										.FindElementById("com.example.androidappsummator:id/buttonCalcSum");

			calcButton.Click();

			//Assert
			AndroidElement resultField = this.driver
									.FindElementById("com.example.androidappsummator:id/editTextSum");

			Assert.AreEqual("error", resultField.Text);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			this.driver.Quit();
		}
	}
}
