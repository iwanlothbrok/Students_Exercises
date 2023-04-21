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

namespace TaskBoard.WebAPI.IntegrationTests
{
    public class ApiTestsWithUser : ApiTestsBase
    {
        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            await base.AuthenticateAsync();
        }

        [Test]
        public async Task Test_Tasks_GetTaskById_ValidId()
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
        public async Task Test_Tasks_CreateTask_ValidData()
        {

        }

        [Test]
        public async Task Test_Tasks_EditTask_ValidId()
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
        public async Task Test_Tasks_EditTask_InvalidId()
        {
        }

        [Test]
        public async Task Test_Tasks_PartialEditTask_ValidId()
        {
        }

        [Test]
        public async Task Test_Tasks_DeleteTask_ValidId()
        {
        }
    }
}
