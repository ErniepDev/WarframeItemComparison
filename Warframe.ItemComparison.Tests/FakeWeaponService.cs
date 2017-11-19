using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warframe.ItemComparison.Tests
{
    class FakeWeaponService : IWeaponService
    {
        public string WeaponsData()
        {
            return "[{\"name\": \"axe of frost\", \"stats\": [{\"name\": \"damage\",\"value\": 3}]},{\"name\": \"sword of fire\", \"stats\": [{\"name\": \"damage\",\"value\": 10}]}]";
        }
    }
}
