namespace Warframe.ItemComparison
{
    internal interface IWeaponService
    {
        string WeaponsData();
    }

    internal class WeaponService : IWeaponService
    {

        public string WeaponsData()
        {
            return "{weapon {name: \"axe of frost\", stats{damage: \"3\"}}";
        }

    }
}