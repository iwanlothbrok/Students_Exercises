using System;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using TaskBoard.WebAPI.Models.Task;
using TaskBoard.WebAPI.Models.Response;

using NUnit.Framework;
using Newtonsoft.Json;
using TaskBoard.Data;

namespace TaskBoard.WebAPI.IntegrationTests
{
    public class ApiTestsWithUser : ApiTestsBase
    {
        [OneTimeSetUp]
        public async System.Threading.Tasks.Task OneTimeSetUp()
        {
            await base.AuthenticateAsync();
        }

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_GetTaskById_ValidId()
        {
            //Arrange
            var cssTaskId = this.testDb.CSSTask.Id;

            //Act
            var respond = await this.httpClient.GetAsync($"/api/tasks/{cssTaskId}");

            //Assert
            Assert.AreEqual(respond.StatusCode, HttpStatusCode.OK);

            var respondContent = respond.Content.
                ReadAsAsync<TaskExtendedListingModel>()
                .Result;

            Assert.AreEqual(this.dbContext.Tasks.Find(cssTaskId).Title , respondContent.Title);
        }

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_CreateTask_ValidData()
        {
            //Arrange

            var changedTask = new Data.Task()
            {

                Title = "New task",
                Description = "There is no description",
                Id = 150, 
			};

			//Act
            await this.dbContext.AddAsync(changedTask);
            await this.dbContext.SaveChangesAsync();

			//Assert
			this.dbContext = this.testDb.CreateDbContext();
			var taskInDbAfter = this.dbContext.Tasks.Find(changedTask.Id);
			Assert.AreEqual(changedTask.Title, taskInDbAfter.Title);
		}

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_EditTask_ValidId()
        {
            //Arrange
            var editTask = this.testDb.EditTask;

            var changedTitle = "Changed CSS Task";
            var changedTask = new TaskBindingModel()
            {
                Title = changedTitle,
                Description = editTask.Description,
                Board = editTask.Board.Name
            };

            //Act
            var putRespond = await this.httpClient.PutAsJsonAsync($"/api/tasks/{editTask.Id}", changedTask);

            //Assert
            Assert.AreEqual(HttpStatusCode.NoContent, putRespond.StatusCode);

            this.dbContext = this.testDb.CreateDbContext();
            var taskInDbAfter = this.dbContext.Tasks.Find(editTask.Id);
            Assert.AreEqual(changedTitle,taskInDbAfter.Title);
        }

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_EditTask_InvalidId()
        {
            //Arrange
            var fakeId = 1233;
            var changedTask = new TaskBindingModel();

			//Act
			var putRespond = await this.httpClient.PutAsJsonAsync($"/api/tasks/{fakeId}", changedTask);

			//Assert
			Assert.AreEqual(HttpStatusCode.BadRequest, putRespond.StatusCode);
		}

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_PartialEditTask_ValidId()
        {
            //Arrange
            var editTask = this.testDb.EditTask;

            var changedTitle = "Changed CSS Task";

            var changedTask = new TaskBindingModel()
            {
                Title = changedTitle,
                Description = editTask.Description,
                Board = editTask.Board.Name
            };


            //Act
            var putResponse = await this.httpClient.PutAsJsonAsync($"/api/tasks/{editTask.Id}", changedTask);

            //Assert
            Assert.AreEqual(HttpStatusCode.NoContent, putResponse.StatusCode);

            this.dbContext = this.testDb.CreateDbContext();
            var taskInDbAfter = this.dbContext.Tasks.Find(editTask.Id);

            Assert.AreEqual(changedTitle,taskInDbAfter.Title);
            
        }

        [Test]
        public async System.Threading.Tasks.Task Test_Tasks_DeleteTask_ValidId()
        {
			//Arrange
			var fakeId = 1233;

			//Act
			var putRespond = await this.httpClient.DeleteAsync($"/api/tasks/{fakeId}");

			//Assert
			Assert.AreEqual(HttpStatusCode.NotFound, putRespond.StatusCode);
		}
    }
}
