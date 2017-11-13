using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warframe.ItemComparison.Models
{
    public interface IWeaponStat
    {
        string ToString();
    }

    public class WeaponStat : IWeaponStat
    {
        private readonly int _amount;
        private readonly string _stat;


        public WeaponStat(string stat)
        {
            _stat = stat;
           
        }

        public WeaponStat(string stat, int amount)
        {
            _stat = stat;
            _amount = amount;
        }

        public override string ToString()
        {
            return $"{_stat}: {_amount}";
        }
    }
}