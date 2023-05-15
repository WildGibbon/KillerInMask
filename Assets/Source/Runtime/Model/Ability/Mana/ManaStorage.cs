using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.View.Mana;
using System;

namespace MaskedKiller.Model.Ability
{
	public class ManaStorage : IManaStorage
	{
		public int CurrentValue { get; private set; }

		private readonly IManaStorageView _view;

		private int _maxValue;

		public ManaStorage(IManaStorageView view, int maxValue)
		{
			if(maxValue <= 0)
				throw new ArgumentOutOfRangeException(nameof(maxValue));

			_view = view ?? throw new ArgumentNullException(nameof(view));
			_maxValue = CurrentValue = maxValue;
		}

		public void AddMana(int amount)
		{
			if(!CanAddMana(amount))
				throw new InvalidOperationException();

			CurrentValue += amount;
			_view.Visualize(CurrentValue, _maxValue);
		}

		public void TakeMana(int amount)
		{
			if (!CanTakeMana(amount))
				throw new InvalidOperationException();

			CurrentValue -= amount;
			_view.Visualize(CurrentValue, _maxValue);
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
