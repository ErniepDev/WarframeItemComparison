using System.Collections.Generic;
using Newtonsoft.Json;

namespace Warframe.ItemComparison
{
    internal interface IWeaponStat
    {
        string ToString();
    }

    internal class WeaponStat : IWeaponStat
    {
        private readonly int _name;
        private readonly string _value;

        [JsonConstructor]
        public WeaponStat(string name, int value)
        {
            _value = name;
            _name = value;
        }

        public override bool Equals(object obj)
        {
            var stat = obj as WeaponStat;
            return stat != null &&
                   _name == stat._name &&
                   _value == stat._value;
        }

        public override int GetHashCode()
        {
            var hashCode = 403100198;
            hashCode = hashCode * -1521134295 + _name.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_value);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{_value}: {_name}";
        }

    }
}