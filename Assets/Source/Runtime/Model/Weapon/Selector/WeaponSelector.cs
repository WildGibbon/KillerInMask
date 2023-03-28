using System;

namespace MaskedKiller.Model.Weapon
{
	public class WeaponSelector : IWeaponSelector
	{
		public IWeapon CurrrentWeapon => _collection.GetWeapon(_currentWeaponIndex);

		private readonly IWeaponCollection _collection;

		private int _currentWeaponIndex = 0;

		public WeaponSelector(IWeaponCollection collection)
		{
			_collection = collection ?? throw new ArgumentNullException(nameof(collection));
		}

		public void SwitchToNextWeapon()
		{
			if(_currentWeaponIndex == _collection.Count - 1)
				_currentWeaponIndex = 0;

			_currentWeaponIndex++;
		}

		public void SwitchToPreviousWeapon()
		{
			if(_currentWeaponIndex == 0)
				_currentWeaponIndex = _collection.Count - 1;

			_currentWeaponIndex--;
		}
	}
}
