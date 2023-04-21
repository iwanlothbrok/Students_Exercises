using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

using TaskBoard.Data;
using TaskBoard.Tests.Common;
using TaskBoard.WebAPI.Models.User;
using TaskBoard.WebAPI.Models.Response;

using NUnit.Framework;

namespace TaskBoard.WebAPI.IntegrationTests
{
    public class ApiTestsBase
    {
        protected TestDb testDb;
        protected ApplicationDbContext dbContext;
        protected TestTaskBoardApp<Startup> testTaskBoardApi;
        protected HttpClient httpClient;

        [OneTimeSetUp]
        public void OneTimeSetUpBase()
        {
            this.testDb = new TestDb();
            this.dbContext = this.testDb.CreateDbContext();
            this.testTaskBoardApi = new TestTaskBoardApp<Startup>(
                this.testDb, "../../../../TaskBoard.WebAPI");
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri(this.testTaskBoardApi.ServerUri)
            };
        }

        public async System.Threading.Tasks.Task AuthenticateAsync()
        {
            this.httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("bearer", await this.GetJWTAsync());
        }

        private async Task<string> GetJWTAsync()
        {
            var userMaria = this.testDb.UserMaria;
            var response = await this.httpClient.PostAsJsonAsync("api/users/login",
                new LoginModel
                {
                    Username = userMaria.UserName,
                    Password = userMaria.UserName
                });

            var loginResponse = await response.Content.ReadAsAsync<ResponseWithToken>();

            return loginResponse.Token;
        }

        [OneTimeTearDown]
        public void OneTimeTearDownBase()
        {
            // Stop and dispose the local Web API server
            this.testTaskBoardApi.Dispose();
        }
    }
}
