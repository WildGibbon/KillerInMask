using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class WeaponSelectorFactory : SerializedMonoBehaviour, IWeaponSelectorFactory
	{
		[SerializeField] private IWeaponCollectionFactory _weaponCollectionFactory;

		public IWeaponSelector Create()
		{
			return new WeaponSelector(_weaponCollectionFactory.Create());
		}
	}
}
