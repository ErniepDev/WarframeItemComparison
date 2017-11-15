using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponStatTests
    {
        [TestMethod]
        public void ShouldReturnStatsOnToString()
        {
            WeaponStat stat = new WeaponStat("Damage",3);

            stat.ToString().Should().Be("Damage: 3");
        }
        [TestMethod]
        public void ShouldBeEqualWhenNameAndValueAreSame()
        {
            IWeaponStat actual = new WeaponStat("damage", 3);
            IWeaponStat expected = new WeaponStat("damage", 3);

            actual.Should().Be(expected);
        }
    }
}
