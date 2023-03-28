using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Factories.Weapon
{
	public interface IWeaponSelectorFactory
	{
		IWeaponSelector Create();
	}
}
