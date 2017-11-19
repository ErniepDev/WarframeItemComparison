using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace Warframe.ItemComparison
{
    public  interface IWeapon
    {
        bool Equals(object obj);
        int GetHashCode();
        string DisplayTitle();
    }

    public sealed class Weapon : IWeapon
    {
        private readonly List<WeaponStat> _stats;
        private readonly string _name;

        [JsonConstructor]
        public  Weapon(string name, List<WeaponStat> stats)
        {
            _name = name;
            _stats = stats;
        }

        public string DisplayTitle()
        {
            return _name;
        }

        public List<WeaponStat> WeaponStats()
        {
            return _stats;
        }

        public override bool Equals(object obj)
        {
            var weapon = obj as Weapon;
            return weapon != null && Equals(weapon);
        }
        
        private bool Equals(Weapon weapon)
        {
            return _stats.Any(w => weapon._stats.Contains(w))
                   && _stats.Count == weapon._stats.Count
                   && _name == weapon._name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1122350698;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<WeaponStat>>.Default.GetHashCode(_stats);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            return hashCode;
        }
    }
}