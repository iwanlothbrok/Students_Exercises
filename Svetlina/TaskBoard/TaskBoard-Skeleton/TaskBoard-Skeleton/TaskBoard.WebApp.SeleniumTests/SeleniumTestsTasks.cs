using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace TaskBoard.WebApp.SeleniumTests
{
	public class SeleniumTestsTasks : SeleniumTestsBase
	{
		[OneTimeSetUp]
		public void SetupUser()
		{
			this.RegisterUserForTesting();
		}

		[Test]
		public void Test_CreateTask_ValidData()
		{
			// Find the username input element using the given xPath
			this.driver.Navigate().GoToUrl(this.baseUrl + "/Tasks/Create");

			IWebElement redirect = driver.FindElement(By.CssSelector("div.form-group p a"));
			redirect.Click();
			
			IWebElement inputUsername = driver.FindElement(By.Id("Input_Username"));
			inputUsername.SendKeys(username);
			
			IWebElement inputEmail = driver.FindElement(By.Id("Input_Email"));
			inputUsername.SendKeys(username + "@abv.bg");

			// Find the password input element using the given xPath
			IWebElement inputPassword = driver.FindElement(By.Id("Input_Password"));
			inputPassword.SendKeys(password);
			IWebElement inputConfirmPassword = driver.FindElement(By.Id("Input_ConfirmPassword"));
			inputPassword.SendKeys(password);
			
			IWebElement inputFirstName= driver.FindElement(By.Id("Input_ConfirmPassword"));
			inputPassword.SendKeys(password);

			// Login button
			IWebElement inputLastName = driver.FindElement(By.CssSelector("div.form-group button[type='submit']"));

			// Click the button
			button.Click();

			Assert.That(this.driver.Title.Contains("Create Task"));

			var taskTitle = "Test Task" + DateTime.Now.Ticks;
			var titleField = this.driver.FindElement(By.Id("Title"));

			titleField.Clear();
			titleField.SendKeys(taskTitle);

			var taskDescription = "Task to test if the tasks creation is successful";
			var descriptionField = this.driver.FindElement(By.Id("Title"));
			descriptionField.Clear();
			descriptionField.SendKeys(taskDescription);


			var boardField = this.driver.FindElement(By.Id("BoardId"));
			boardField.Click();

			var inProgressOption = this.driver.FindElement(By.XPath(@"//*[@id='BoardId']/option[2]"));
			inProgressOption.Click();

			// Location Create btn
			var createButton = this.driver.FindElement(By.XPath("//input[contains(@value,'Create')]"));

			createButton.Click();

			//Assert 
			Assert.AreEqual(this.baseUrl + "/Boards", this.driver.Url);
			Assert.That(this.driver.Title.Contains("Task Board"));
			Assert.That(this.driver.PageSource.Contains("Task Board"));

			Assert.That(this.driver.PageSource.Contains(taskTitle));
			Assert.That(this.driver.PageSource.Contains(taskDescription));
			Assert.That(this.driver.PageSource.Contains(this.username));

			var taskTableBodyElement =
				this.driver.FindElement(By.XPath($"//tbody[contains(.,'{taskTitle}')]"));
			var taskTableDataRows = taskTableBodyElement.FindElement(By.TagName("td"));

			Assert.AreEqual(taskTableDataRows.Text[0], taskTitle);
			Assert.AreEqual(taskTableDataRows.Text[1], taskDescription);
			//Assert.AreEqual(taskTableDataRowsText[2].);
			
		}

		[Test]
		public void Test_CreateTask_InvalidData()
		{
		}

		[Test]
		public void Test_DeleteTask()
		{
		}

		[Test]
		public void Test_EditTask_ValidData()
		{
		}

		private void RegisterUserForTesting()
		{
		}

		//private void CreateTask(out string taskTitle, out string taskDescription)
		//{
		//}
	}
}
