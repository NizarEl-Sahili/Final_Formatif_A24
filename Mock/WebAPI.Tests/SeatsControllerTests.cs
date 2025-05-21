using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebAPI.Controllers;
using WebAPI.Services;

namespace WebAPI.Tests;

[TestClass]
public class SeatsControllerTests
{
    Mock<SeatsService> mock1;
    Mock<SeatsController> mock2;
    public SeatsControllerTests()
    {
        mock1 = new Mock<SeatsService>();
        mock2 = new Mock<SeatsController>(mock1.Object) { CallBase = true };
        mock2.Setup(c => c.UserId).Returns("11111");
    }

    [TestMethod]
    public void ReserveSeat()
    {




    }
}
