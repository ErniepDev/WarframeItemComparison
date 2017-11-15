using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Warframe.ItemComparison
{
    internal class WeaponBuilder
    {
        private string _weaponData;

        public WeaponBuilder(string weaponData)
        {
            _weaponData = weaponData;
        }

        internal List<Weapon> BuildWeapons()
        {
            return JsonConvert.DeserializeObject<List<Weapon>>(_weaponData);
        }
    }
}