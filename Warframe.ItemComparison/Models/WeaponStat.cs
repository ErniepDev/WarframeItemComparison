using System.Collections.Generic;
using Newtonsoft.Json;

namespace Warframe.ItemComparison
{
    public interface IWeaponStat
    {
        bool Equals(object obj);
        int GetHashCode();
        string Display();
    }

    public sealed class WeaponStat : IWeaponStat
    {
        private readonly string _name;
        private readonly int _value;

        [JsonConstructor]
        public  WeaponStat(string name, int value)
        {
            _value = value;
            _name = name;
        }

        public override bool Equals(object obj)
        {
            var stat = obj as WeaponStat;
            return stat != null && Equals(stat);  
        }

        private bool Equals(WeaponStat stat)
        {
            return _name == stat._name &&
                  _value == stat._value;
        }

        public override int GetHashCode()
        {
            var hashCode = 403100198;
            hashCode = hashCode * -1521134295 + _name.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            return hashCode;
        }

        public string Display()
        {
            return $"{_name}: {_value}";   
        } 
    }
}