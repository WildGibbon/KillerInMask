using MaskedKiller.Model.Health;
using System;

namespace MaskedKiller.Model.Attack
{
	public class DefaultAttack : IAttack
	{
		private readonly int _damage;

		public DefaultAttack(int damage)
		{
			if(damage <= 0)
				throw new ArgumentOutOfRangeException(nameof(damage));

			_damage = damage;
		}

		public void Attack(IHealth health)
		{
			if(!health.IsDead)
				health.TakeDamage(_damage);
		}
	}
}
