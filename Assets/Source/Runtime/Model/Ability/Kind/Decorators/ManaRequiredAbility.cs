using MaskedKiller.Model.Ability.Mana;
using System;

namespace MaskedKiller.Model.Ability.Kind
{
	public class ManaRequiredAbility : IAbility
	{
		public bool CanUse => _ability.CanUse && _manaStorage.CanTakeMana(_useCost);

		private readonly IManaStorage _manaStorage;
		private readonly IAbility _ability;
		private readonly int _useCost;

		public ManaRequiredAbility(IManaStorage manaStorage, IAbility ability, int useCost)
		{
			if(useCost < 0)
				throw new ArgumentOutOfRangeException(nameof(useCost));

			_manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));
			_ability = ability ?? throw new ArgumentNullException(nameof(ability));
			_useCost = useCost;
		}

		public void Use()
		{
			if (!CanUse)
				throw new InvalidOperationException();

			_manaStorage.TakeMana(_useCost);
			_ability.Use();
		}

		public void CancelUse()
		{
			_ability.CancelUse();
		}
	}
}
