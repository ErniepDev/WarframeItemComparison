using System.Collections.Generic;
using Warframe.ItemComparison.Models;

namespace Warframe.ItemComparison
{
    internal interface IWeaponService
    {
        string WeaponsData();
    }

    public class WeaponService : IWeaponService
    {

        public string WeaponsData()
        {
            return "{weapon {name: \"axe of frost\", stats{damage: \"3\"}}";
        }
    }
}