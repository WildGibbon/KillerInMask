using System.Collections.Generic;
using MaskedKiller.Model.Weapon;
using MaskedKiller.View;
using System;

namespace MaskedKiller.Model.Selector
{
	public class WeaponSelector : ISelector<IWeapon>
	{
		public IWeapon CurrrentItem => _currentWeaponWithImage.Weapon;

		private readonly List<WeaponWithImage> _items;
		private readonly IWeaponSelectorView _view;

		private WeaponWithImage _currentWeaponWithImage => _items[_currentWeaponIndex];
		private int _currentWeaponIndex = 0;
		
		public WeaponSelector(List<WeaponWithImage> items)
		{
			_items = items ?? throw new ArgumentNullException(nameof(items));

			_view.Visualize(_currentWeaponWithImage.Image);
		}

		public void NextItem()
		{
			if(_currentWeaponIndex == _items.Count - 1)
				_currentWeaponIndex = 0;
			else
				_currentWeaponIndex++;

			_view.Visualize(_currentWeaponWithImage.Image);
		}

		public void PreviousItem()
		{  
			if (_currentWeaponIndex == 0)
				_currentWeaponIndex = _items.Count - 1;
			else
				_currentWeaponIndex--;

			_view.Visualize(_currentWeaponWithImage.Image);
		}
	}
}
