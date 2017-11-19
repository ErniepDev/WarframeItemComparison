using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warframe.ItemComparison.Controllers;
using FluentAssertions;
using System.Collections.Generic;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod, TestCategory("Unit")]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnViewResult()
        {
            HomeController controller = new HomeController();

            var result = controller.Index();

            result.Should().BeOfType<ViewResult>();
  
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldHaveExpectedModel()
        {
            string weaponData = "[{\"name\": \"axe of frost\", \"stats\": [{\"name\": \"damage\",\"value\": 3}]},{\"name\": \"sword of fire\", \"stats\": [{\"name\": \"damage\",\"value\": 10}]}]";
            WeaponService weaponService = new WeaponService(weaponData);
            HomeController controller = new HomeController(weaponService);
            List<Weapon> expected = new WeaponBuilder(weaponService.WeaponsData()).BuildWeapons();

            var actual = controller.Index().Model as List<Weapon>;

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
