using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class FireArmFactory : SerializedMonoBehaviour, IWeaponFactory
	{
		[SerializeField] private IBulletFactory _bulletFactory;

		public IWeapon Create()
		{
			return new FireArm(_bulletFactory);
		}
	}
}
