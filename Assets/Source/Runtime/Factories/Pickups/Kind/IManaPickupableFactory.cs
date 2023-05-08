using MaskedKiller.Model.Ability.Mana;

namespace MaskedKiller.Factories.Pickups
{
	public interface IManaPickupableFactory : IPickupableFactory
	{
		void Init(IManaStorage manaStorage);
	}
}
