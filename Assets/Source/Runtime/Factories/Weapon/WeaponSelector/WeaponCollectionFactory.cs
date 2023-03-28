using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class WeaponCollectionFactory : SerializedMonoBehaviour, IWeaponCollectionFactory
	{
		[SerializeField] private List<IWeaponFactory> _factories;

		public IWeaponCollection Create()
		{
			List<IWeapon> weapons = new List<IWeapon>();

			foreach (var factory in _factories)
			{
				weapons.Add(factory.Create());
			}

			return new WeaponCollection(weapons);
		}
	}
}
