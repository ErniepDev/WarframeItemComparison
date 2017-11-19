using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Warframe.ItemComparison
{
    public class WeaponViewModel
    {
        public List<Weapon> Weapons { get; set; }
        
        public WeaponViewModel(List<Weapon> weapons) {

            Weapons = weapons;
        }
    }
}