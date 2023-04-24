using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.ComponentModel.DataAnnotations;

namespace TaskBoard.WebApp.SeleniumTests
{
	public class SeleniumTestsTasks : SeleniumTestsBase
	{
		[OneTimeSetUp]
		public void SetupUser()
		{
			this.LoginForm();
		}

		[Test]
		public void Test_CreateTask_ValidData()
		{
			// Find the username input element using the given xPath
			//this.driver.Navigate().GoToUrl(this.baseUrl + "/Tasks/Create");

			// Click the button and login 
			//LoginForm();

			Assert.That(this.driver.Title.Contains("Create Task"));

			var taskTitle = "Test Task";
			var titleField = this.driver.FindElement(By.Id("Title"));
			titleField.Clear();
			titleField.SendKeys(taskTitle);

			var taskDescription = "Task to test if the tasks creation is successful";
			var descriptionField = this.driver.FindElement(By.Id("Description"));
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


			Assert.AreEqual(taskTableDataRows.Text, taskTitle);
		}


		[Test]
		public void Test_CreateTask_InvalidData()
		{

			// Find the username input element using the given xPath
			this.driver.Navigate().GoToUrl(this.baseUrl + "/Tasks/Create");

			// Click the button and login 
			//LoginForm();

			Assert.That(this.driver.Title.Contains("Create Task"));

			var titleField = this.driver.FindElement(By.Id("Title"));
			titleField.Clear();

			var taskDescription = "Task to test if the tasks creation is successful";
			var descriptionField = this.driver.FindElement(By.Id("Description"));
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
			Assert.AreEqual(this.baseUrl + "/Tasks/Create", this.driver.Url);

			var errorSpan = this.driver.FindElement(By.Id("Title-error"));
			Assert.AreEqual(errorSpan.Text, "The Title field is required.");
		}

		[Test]
		public void Test_DeleteTask()
		{
			string taskTitle = "Test Task";
			//this.Test_CreateTask_ValidData();

			Assert.AreEqual(this.baseUrl + "/Boards", this.driver.Url);
			Assert.That(this.driver.PageSource.Contains(taskTitle));


			var taskTableBody =
				this.driver.FindElement(By.XPath($"//tbody[contains(.,'{taskTitle}')]"));

			var taskTableRow =
			this.driver.FindElement(By.XPath("//tr[@class='actions']"));

			var deleteBtn =
				this.driver.FindElement(By.XPath($"//td/a[contains(.,'Delete')]"));


			deleteBtn.Click();
			//Assert
			Assert.That(this.driver.Url.Contains("/Tasks/Delete/"));	
			Assert.That(this.driver.Title.Contains("Delete Task"));	
			Assert.That(this.driver.PageSource.Contains(taskTitle));

			var confirmDeleteBtn = this.driver
									.FindElement(By.XPath("//input[contains(@value,'Delete')]"));

			confirmDeleteBtn.Click();

			Assert.That(this.driver.PageSource.Contains(taskTitle) == false);
		}

		[Test]
		public void Test_EditTask_ValidData()
		{
			this.driver.Navigate().GoToUrl(this.baseUrl + "/Tasks/Create");

			string taskTitle = "Test Task";
			this.Test_CreateTask_ValidData();

			Assert.AreEqual(this.baseUrl + "/Boards", this.driver.Url);

			var taskTableBody =
				this.driver.FindElement(By.XPath($"//tbody[contains(.,'{taskTitle}')]"));

			var taskTableRow =
			this.driver.FindElement(By.XPath("//tr[@class='actions']"));

			var editBtn =
				this.driver.FindElement(By.XPath($"//td/a[contains(.,'Edit')]"));


			editBtn.Click();
			//Assert
			Assert.That(this.driver.Url.Contains("/Tasks/Edit/"));
			Assert.That(this.driver.Title.Contains("Edit Task"));

			var newTaskTitle = "New New";
			var titleField = this.driver.FindElement(By.Id("Title"));
			titleField.Clear();
			titleField.SendKeys(newTaskTitle);

			var confirmEditBtn = this.driver
									.FindElement(By.XPath("//input[contains(@value,'Edit')]"));

			confirmEditBtn.Click();

			Assert.That(this.driver.PageSource.Contains(newTaskTitle));
			Assert.That(this.driver.PageSource.Contains(taskTitle) == false);
		}

		private void LoginForm()
		{
			this.driver.Navigate().GoToUrl(this.baseUrl + "/Tasks/Create");

			IWebElement redirect = driver.FindElement(By.CssSelector("div.form-group p a"));
			redirect.Click();

			IWebElement inputUsername = driver.FindElement(By.Id("Input_Username"));
			inputUsername.SendKeys(username);

			IWebElement inputEmail = driver.FindElement(By.Id("Input_Email"));
			inputEmail.SendKeys(username + "@abv.bg");

			// Find the password input element using the given xPath
			IWebElement inputPassword = driver.FindElement(By.Id("Input_Password"));
			inputPassword.SendKeys(password);
			IWebElement inputConfirmPassword = driver.FindElement(By.Id("Input_ConfirmPassword"));
			inputConfirmPassword.SendKeys(password);

			IWebElement inputFirstName = driver.FindElement(By.Id("Input_FirstName"));
			inputFirstName.SendKeys(password);

			IWebElement inputLastName = driver.FindElement(By.Id("Input_LastName"));
			inputLastName.SendKeys(password);

			// Login button
			IWebElement registerButton = driver.FindElement(By.CssSelector("button.btn.btn-primary"));
			registerButton.Click();
		}
	}
}
