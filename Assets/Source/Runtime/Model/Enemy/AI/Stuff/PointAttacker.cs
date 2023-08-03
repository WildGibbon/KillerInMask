using MaskedKiller.Model.Weapon;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public class PointAttacker : IPointAttacker
	{
		private readonly Transform _attackerTransform;
		private readonly IWeapon _weapon;

		public PointAttacker(Transform attackerTransform, IWeapon weapon)
		{
			_attackerTransform = attackerTransform ?? throw new ArgumentNullException(nameof(attackerTransform));
			_weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
		}

		public void Use(Vector2 point)
		{
			var transformPosition = new Vector2(_attackerTransform.position.x, _attackerTransform.position.y);
			var attackDirection = (point - transformPosition).normalized;

			if(_weapon.CanAttack)
				_weapon.AttackIn(attackDirection);
		}
	}
}
