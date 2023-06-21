using MaskedKiller.Model.Attack;
using MaskedKiller.Model.Health;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Weapon.Kind
{
	public class MeleeWeapon : IWeapon
	{
		public bool CanAttack => true;

		private readonly Transform _raycastSourcePoint;
		private readonly float _attackDistance;
		private readonly IAttack _attack;

		public MeleeWeapon(Transform raycastSourcePoint, float attackDistance, IAttack attack)
		{
			if(attackDistance <= 0)
				throw new ArgumentOutOfRangeException(nameof(attackDistance));

			_raycastSourcePoint = raycastSourcePoint ?? throw new ArgumentNullException(nameof(raycastSourcePoint));
			_attack = attack ?? throw new ArgumentNullException(nameof(attack));
			_attackDistance = attackDistance;
		}

		public void AttackIn(Vector2 direction)
		{
			var raycastHit = Physics2D.Raycast(_raycastSourcePoint.position, direction, _attackDistance);

			if (raycastHit)
			{
				_attack.Attack(raycastHit.transform.GetComponent<IHealth>());
				raycastHit.rigidbody.AddForce(direction * 1000);//добавлено по рофлу
			}
		}
	}
}