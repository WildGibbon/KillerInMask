using System;
using System.Collections.Generic;

namespace MaskedKiller.Model.Weapon
{
	public class WeaponCollection : IWeaponCollection
	{
		public int Count => _weapons.Count;

		private readonly List<IWeapon> _weapons;

		public WeaponCollection(List<IWeapon> weapons)
		{
			_weapons = weapons ?? throw new ArgumentNullException(nameof(weapons));
		}

		public void Add(IWeapon weapon)
		{
			_weapons.Add(weapon);
		}

		public IWeapon GetWeapon(int index)
		{
			return _weapons[index];
		}

		public void Remove(int index)
		{
			throw new System.NotImplementedException();
		}
	}
}
