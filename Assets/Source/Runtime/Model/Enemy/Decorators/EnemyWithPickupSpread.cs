using MaskedKiller.Model.Pickups;
using MaskedKiller.Model.Health;
using System;

namespace MaskedKiller.Model.Enemy
{
	public class EnemyWithAfterDeathReward : IEnemy
	{
		private readonly ISpreader _spreader; //задумано, что будет выбрасывать пикапы
		private readonly IHealth _health;
		private readonly IEnemy _enemy;

		public EnemyWithAfterDeathReward(ISpreader spreader, IHealth health, IEnemy enemy)
		{
			_spreader = spreader ?? throw new ArgumentNullException(nameof(spreader));
			_health = health ?? throw new ArgumentNullException(nameof(health));
			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
		}

		public void Update(float deltaTime)
		{
			if(_health.IsDead)
				_spreader.Use();

			_enemy.Update(deltaTime);
		}
	}
}
