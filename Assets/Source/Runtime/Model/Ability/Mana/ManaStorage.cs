using MaskedKiller.Model.Ability.Mana;
using System;

namespace MaskedKiller.Model.Ability
{
	public class ManaStorage : IManaStorage
	{
		public int CurrentValue { get; private set; }

		private int _maxValue;

		public ManaStorage(int maxValue)
		{
			if(maxValue <= 0)
				throw new ArgumentOutOfRangeException(nameof(maxValue));

			_maxValue = CurrentValue = maxValue;
		}

		public void AddMana(int amount)
		{
			if(!CanAddMana(amount))
				throw new InvalidOperationException();

			CurrentValue += amount;
		}

		public void TakeMana(int amount)
		{
			if (!CanTakeMana(amount))
				throw new InvalidOperationException();

			CurrentValue -= amount;
		}

		public bool CanAddMana(int amount)
		{
			return CurrentValue + amount <= _maxValue;
		}

		public bool CanTakeMana(int amount)
		{
			return CurrentValue - amount >= 0;
		}
	}
}
