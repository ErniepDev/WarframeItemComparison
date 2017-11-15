using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace Warframe.ItemComparison
{
    internal interface IWeapon
    {
        string ToString();
        List<WeaponStat> WeaponStats();
    }

    internal class Weapon : IWeapon
    {
        private readonly List<WeaponStat> _stats;
        private readonly string _name;

        public Weapon(string name) : this(name, new List<WeaponStat>())
        {
            
        }
        [JsonConstructor]
        public Weapon(string name, List<WeaponStat> stats)
        {
            _name = name;
            _stats = stats;
        }

        public override bool Equals(object obj)
        {
            var weapon = obj as Weapon;
            return weapon != null 
                   && _stats.Any(w => weapon._stats.Contains(w)) 
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

        public override string ToString()
        {
            return _name;
        }

        public List<WeaponStat> WeaponStats()
        {
            return _stats;
        }


    }
}