using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warframe.ItemComparison.Models;

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
    }
}
