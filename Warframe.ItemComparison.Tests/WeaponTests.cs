using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnTitleOnTitleDisplay()
        {
            List<WeaponStat> stats = new List<WeaponStat>() { new WeaponStat("damage", 3) };

            Weapon actual = new Weapon("Axe of Frost", stats);

            actual.DisplayTitle().Should().Be("Axe of Frost");
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldBeEqualWhenNameAndStatsAreSame()
        {
            List<WeaponStat> stats = new List<WeaponStat>() { new WeaponStat("damage",3) };

            Weapon actual = new Weapon("Axe of Frost", stats);
            Weapon expected = new Weapon("Axe of Frost", new List<WeaponStat> { new WeaponStat("damage",3) });

            expected.Should().Be(actual);
        }
    }
}
