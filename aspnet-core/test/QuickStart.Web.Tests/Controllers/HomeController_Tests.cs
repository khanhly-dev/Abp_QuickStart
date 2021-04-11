using System.Threading.Tasks;
using QuickStart.Models.TokenAuth;
using QuickStart.Web.Controllers;
using Shouldly;
using Xunit;

namespace QuickStart.Web.Tests.Controllers
{
    public class HomeController_Tests: QuickStartWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}