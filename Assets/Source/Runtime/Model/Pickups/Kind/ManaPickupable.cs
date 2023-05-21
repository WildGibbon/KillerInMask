using MaskedKiller.Model.Ability.Mana;
using System;

namespace MaskedKiller.Model.Pickups
{
	public class ManaPickupable : IPickupable
	{
		private readonly IManaStorage _manaStorage;
		private readonly int _manaIncreaseValue;

		public ManaPickupable(IManaStorage manaStorage, int manaIncreaseValue)
		{
			if(manaIncreaseValue <= 0)
				throw new ArgumentOutOfRangeException(nameof(manaIncreaseValue));

			_manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));
			_manaIncreaseValue = manaIncreaseValue;
		}

		public void Pickup()
		{
			if(_manaStorage.CanAddMana(_manaIncreaseValue))
				_manaStorage.AddMana(_manaIncreaseValue);
		}
	}
}
