namespace Warframe.ItemComparison
{
    internal interface IWeaponService
    {
        string WeaponsData();
    }

    internal class WeaponService : IWeaponService
    {
        private string _weaponData;

        public WeaponService() : this(string.Empty) { }

        public WeaponService(string weaponData)
        {
            this._weaponData = weaponData;
        }

        public string WeaponsData()
        {
            return _weaponData;
        }

    }
}