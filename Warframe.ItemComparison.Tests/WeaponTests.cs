using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponTests
    {
        [TestMethod]
        public void ShouldReturnNameOnToString()
        {
            Weapon weapon = new Weapon("Axe of Frost");

            weapon.ToString().Should().Be("Axe of Frost");
        }

        [TestMethod]
        public void ShouldReturnStats()
        {
            List<WeaponStat> stats = new List<WeaponStat>(){new WeaponStat("damage",3)};

            Weapon weapon = new Weapon("Axe of Frost",stats);

            weapon.WeaponStats().Should().BeSameAs(stats);
        }

        [TestMethod]
        public void ShouldBeEqualWhenNameAndStatsAreSame()
        {
            List<WeaponStat> stats = new List<WeaponStat>() { new WeaponStat("damage",3) };

            Weapon actual = new Weapon("Axe of Frost", stats);
            Weapon expected = new Weapon("Axe of Frost", new List<WeaponStat> { new WeaponStat("damage",3) });

            expected.Should().Be(actual);
        }
    }
}
