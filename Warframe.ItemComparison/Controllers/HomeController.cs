using System.Collections.Generic;
using System.Web.Mvc;

namespace Warframe.ItemComparison.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeaponService _weaponService;

        public HomeController() : this(new WeaponService())
        {
        }

        internal HomeController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet]
        public ViewResult Index()
        {
            string weaponData = "[{\"name\": \"axe of frost\", \"stats\": [{\"name\": \"damage\",\"value\": 3}]},{\"name\": \"sword of fire\", \"stats\": [{\"name\": \"damage\",\"value\": 10}]}]";
            //string weaponData = _weaponService.WeaponsData();

            List<Weapon> weapons = new WeaponBuilder(weaponData).BuildWeapons();

            return View(weapons);
        }
    }
}