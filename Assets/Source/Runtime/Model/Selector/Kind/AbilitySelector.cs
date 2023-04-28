using System.Collections.Generic;
using MaskedKiller.Model.Ability;
using System;

namespace MaskedKiller.Model.Selector
{
	public class AbilitySelector : ISelector<IAbility>
	{
		public IAbility CurrrentItem => _items[_currentWeaponIndex];

		private readonly List<IAbility> _items;

		private int _currentWeaponIndex = 0;

		public AbilitySelector(List<IAbility> items)
		{
			_items = items ?? throw new ArgumentNullException(nameof(items));
		}

		public void NextItem()
		{
			if (_currentWeaponIndex == _items.Count - 1)
				_currentWeaponIndex = 0;
			else
				_currentWeaponIndex++;
		}

		public void PreviousItem()
		{
			if (_currentWeaponIndex == 0)
				_currentWeaponIndex = _items.Count - 1;
			else
				_currentWeaponIndex--;
		}
	}
}
