using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponStatTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldBeEqualWhenNameAndValueAreSame()
        {
            IWeaponStat actual = new WeaponStat("damage", 3);
            IWeaponStat expected = new WeaponStat("damage", 3);

            actual.Should().Be(expected);
        }

        [TestMethod, TestCategory("Unit")]
        public void DisplayShouldReturnExpectedStringDetails()
        {
            string expected = "damage: 3";
            string actual = new WeaponStat("damage", 3).Display();
  
            expected.Should().Be(actual);
        }

    }
}
