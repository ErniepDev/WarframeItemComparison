using System.Linq;
using System.Web.Mvc;

namespace Warframe.ItemComparison.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeaponService _weaponService;

        public HomeController() : this(new WeaponService())
        {
        }

        public HomeController(WeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpGet]
        public ViewResult Index()
        {
            return View(_weaponService);

        }

    }
}