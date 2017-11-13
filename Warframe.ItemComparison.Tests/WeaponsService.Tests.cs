using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponsModelTests
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
