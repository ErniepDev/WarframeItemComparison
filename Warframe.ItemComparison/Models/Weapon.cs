using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warframe.ItemComparison.Models;

namespace Warframe.ItemComparison
{
    public interface IWeapon
    {
        string ToString();
        List<WeaponStat> WeaponStats();
    }

public class Weapon : IWeapon
    {
        private readonly List<WeaponStat> _weaponStats;
        private readonly string _weaponName;

        public Weapon(string weaponName) : this(weaponName, new List<WeaponStat>())
        {
            
        }

        public Weapon(string weaponName, List<WeaponStat> weaponStats)
        {
            _weaponName = weaponName;
            _weaponStats = weaponStats;

        }


        public override string ToString()
        {
            return _weaponName;
        }

        public List<WeaponStat> WeaponStats()
        {
            return _weaponStats;
        }
    }
}