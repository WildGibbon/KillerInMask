using System.Collections.Generic;
using MaskedKiller.Model.Weapon;
using MaskedKiller.View;
using System;

namespace MaskedKiller.Model.Selector
{
	public class WeaponSelector : ISelector<IWeapon>
	{
		public IWeapon CurrrentItem => _currentWeaponWithSprite.Weapon;

		private readonly List<WeaponWithSprite> _items;
		private readonly IWeaponSelectorView _view;

		private WeaponWithSprite _currentWeaponWithSprite => _items[_currentWeaponIndex];
		private int _currentWeaponIndex = 0;
		
		public WeaponSelector(IWeaponSelectorView view, List<WeaponWithSprite> items)
		{
			_items = items ?? throw new ArgumentNullException(nameof(items));
			_view = view ?? throw new ArgumentNullException(nameof(view));

			_view.Visualize(_currentWeaponWithSprite.Sprite);
		}

		public void NextItem()
		{
			if(_currentWeaponIndex == _items.Count - 1)
				_currentWeaponIndex = 0;
			else
				_currentWeaponIndex++;

			_view.Visualize(_currentWeaponWithSprite.Sprite);
		}

		public void PreviousItem()
		{  
			if (_currentWeaponIndex == 0)
				_currentWeaponIndex = _items.Count - 1;
			else
				_currentWeaponIndex--;

			_view.Visualize(_currentWeaponWithSprite.Sprite);
		}
	}
}
