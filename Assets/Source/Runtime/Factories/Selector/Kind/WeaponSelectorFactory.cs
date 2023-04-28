using MaskedKiller.Factories.Weapon;
using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Factories.Selector
{
	public class WeaponSelectorFactory : SerializedMonoBehaviour, ISelectorFactory<IWeapon>
	{
		[SerializeField] private List<IWeaponFactory> _weaponFactories;

		public ISelector<IWeapon> Create()
		{
			var weapons = new List<IWeapon>();
			_weaponFactories.ForEach(factory => weapons.Add(factory.Create()));
			
			return new WeaponSelector(weapons);
		}
	}
}
