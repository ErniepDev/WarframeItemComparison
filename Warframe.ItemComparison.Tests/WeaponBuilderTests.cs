using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Warframe.ItemComparison.Tests
{
    [TestClass]
    public class WeaponBuilderTests
    {
        [TestMethod]
        public void ShouldReturnWeaponsWithStats()
        {
            string weaponData = "[{\"name\": \"axe of frost\", \"stats\": [{\"name\": \"damage\",\"value\": 3}]},{\"name\": \"sword of fire\", \"stats\": [{\"name\": \"damage\",\"value\": 10}]}]";          

            WeaponBuilder weaponBuilder = new WeaponBuilder(weaponData);
            List<Weapon> expected = new List<Weapon> { new Weapon("axe of frost", new List<WeaponStat> { new WeaponStat("damage", 3)}), new Weapon("sword of fire", new List<WeaponStat> { new WeaponStat("damage", 10) }) };

            List<Weapon> actual = weaponBuilder.BuildWeapons();

            expected.Should().BeEquivalentTo(actual);
        }
    }
}
