using System.Web.Mvc;

namespace Warframe.ItemComparison.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeaponService _weaponService;

        public HomeController() : this(new WeaponService())
        {
        }

        internal HomeController(WeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet]
        internal ViewResult Index()
        {
            return View(_weaponService);

        }

    }
}