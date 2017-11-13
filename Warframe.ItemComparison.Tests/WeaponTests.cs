using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Warframe.ItemComparison.Models;

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

          
            List<WeaponStat> stats = new List<WeaponStat>(){new WeaponStat("damage: 3")};

            Weapon weapon = new Weapon("Axe of Frost",stats);

            weapon.WeaponStats().Should().BeSameAs(stats);

        }
    }
}
