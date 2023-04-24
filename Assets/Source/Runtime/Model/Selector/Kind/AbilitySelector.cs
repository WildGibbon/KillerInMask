using MaskedKiller.Model.Ability;
using System.Collections.Generic;
using System;

namespace MaskedKiller.Model.Selector
{
	public class AbilitySelector : ISelector<IAbility>
	{
		public IAbility CurrrentItem => _abilities[_currentWeaponIndex];

		private readonly List<IAbility> _abilities;

		private int _currentWeaponIndex = 0;

		public AbilitySelector(List<IAbility> abilities)
		{
			_abilities = abilities ?? throw new ArgumentNullException(nameof(abilities));
		}

		public void NextItem()
		{
			if (_currentWeaponIndex == _abilities.Count - 1)
				_currentWeaponIndex = 0;
			else
				_currentWeaponIndex++;
		}

		public void PreviousItem()
		{
			if (_currentWeaponIndex == 0)
				_currentWeaponIndex = _abilities.Count - 1;
			else
				_currentWeaponIndex--;
		}
	}
}
