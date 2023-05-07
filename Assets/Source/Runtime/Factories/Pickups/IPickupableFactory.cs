using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Pickups;

namespace MaskedKiller.Factories.Pickups
{
	public interface IPickupableFactory
	{
		IPickupable Create();
	}
}
