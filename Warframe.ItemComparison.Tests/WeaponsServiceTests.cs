using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponsServiceTests
    {
        [TestMethod]
        public void ShouldReturnWeaponsData()
        {
            WeaponService weasponService = new WeaponService();

            var weaponsData = weasponService.WeaponsData();

            weaponsData.Should().Be("{weapon {name: \"axe of frost\", stats{damage: \"3\"}}");
        }
    }
}
