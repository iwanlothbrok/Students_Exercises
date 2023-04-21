using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using System;
using System.Linq;
using TaskBoard.Data;
using TaskBoard.Tests.Common;
using TaskBoard.WebApp.Controllers;
using TaskBoard.WebApp.Models.Task;

namespace TaskBoard.WebApp.UnitTests
{
    public class TasksControllerTests : UnitTestsBase
    {
        private TasksController controller;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Instantiate the controller class with the testing database
            this.controller = new TasksController(
                this.testDb.CreateDbContext());
            // Set UserMaria as current logged user
            TestingUtils.AssignCurrentUserForController(this.controller, this.testDb.UserMaria);
        }

        [Test]
        public void Test_Create_PostValidData()
        {
            // Arrange
            int taskCountBefore = this.dbContext.Tasks.Count();


            var newTask = new TaskFormModel
            {
                Title = "Test Task" + DateTime.Now.Ticks,
                Description = "Task to test if the task creation is succsessful",
                BoardId = this.testDb.OpenBoard.Id,
            };

            // Act
            var result = this.controller.Create(newTask);

			// Assert redirect
			var redirectResult = result as RedirectToActionResult;
            Assert.AreEqual("Boards", redirectResult.ControllerName);
            Assert.AreEqual("All", redirectResult.ActionName);

            // Assert count 
            int taskCounterAfter = this.dbContext.Tasks.Count();
            Assert.AreEqual(taskCountBefore + 1, taskCounterAfter);

            // Assert if is added
            var newTaskInDb = this.dbContext.Tasks.FirstOrDefault(t=>t.Title == newTask.Title);
            Assert.IsTrue(newTaskInDb.Id > 0);
        }


        [Test]
        public void Test_DeletePage_ValidId()
        {
            // create a task from model
            var newTask = new Task()
            {
                Title = "Test Task" + DateTime.Now.Ticks,
                Description = "Task to test if the tasks creation is succsessful",
                CreatedOn = DateTime.Now,
                BoardId = this.testDb.OpenBoard.Id,
                OwnerId = this.testDb.UserMaria.Id
            };

            this.dbContext.Add(newTask);
            this.dbContext.SaveChanges();

            // Act
            var result = this.controller.Delete(newTask.Id);

            // Assert 
            var viewResult = result as ViewResult;
            Assert.IsNotNull(viewResult);


            var resultModel = viewResult.Model as TaskViewModel;
            Assert.IsNotNull(resultModel);
        }

        [Test]
        public void Test_Delete_UnauthorizedUser()
        {
        }

        [Test]
        public void Test_Edit_ValidId()
        {
        }

        [Test]
        public void Test_Edit_InvalidId()
        {
        }

        [Test]
        public void Test_Edit_UnauthorizedUser()
        {
        }
    }
}
