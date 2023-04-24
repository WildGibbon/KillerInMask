using System.Collections.Generic;
using MaskedKiller.Model.Weapon;
using System;

namespace MaskedKiller.Model.Selector
{
	public class WeaponSelector : ISelector<IWeapon>
	{
		public IWeapon CurrrentItem => _weapons[_currentWeaponIndex];

		private readonly List<IWeapon> _weapons;

		private int _currentWeaponIndex = 0;

		public WeaponSelector(List<IWeapon> weapons)
		{
			_weapons = weapons ?? throw new ArgumentNullException(nameof(weapons));
		}

		public void NextItem()
		{
			if(_currentWeaponIndex == _weapons.Count - 1)
				_currentWeaponIndex = 0;
			else
				_currentWeaponIndex++;
		}

		public void PreviousItem()
		{
			if (_currentWeaponIndex == 0)
				_currentWeaponIndex = _weapons.Count - 1;
			else
				_currentWeaponIndex--;
		}
	}
}
