using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warframe.ItemComparison.Controllers;
using FluentAssertions;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldReturnViewResult()
        {
            HomeController controller = new HomeController();

            var result = controller.Index();

            result.Should().BeOfType<ViewResult>();
  
        }

        [TestMethod]
        public void ShouldPassModelToHomeController()
        {
            WeaponService weapons = new WeaponService();
            HomeController controller = new HomeController(weapons);


            ViewResult result = controller.Index();

            result.Model.Should().Be(weapons);
        }
    }
}
