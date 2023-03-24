using MaskedKiller.Factories;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Weapon
{
	public class FireArm : IWeapon
	{
		public bool CanAttack => true;

		private readonly IBulletFactory _bulletFactory;

		public FireArm(IBulletFactory bulletFactory)
		{
			_bulletFactory = bulletFactory ?? throw new ArgumentNullException(nameof(bulletFactory));
		}

		public void AttackIn(Vector2 direction)
		{
			_bulletFactory.Create().Throw(direction);
		}
	}
}
