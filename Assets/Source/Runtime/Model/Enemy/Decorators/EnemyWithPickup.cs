using MaskedKiller.Model.Pickups;
using MaskedKiller.Model.Health;
using System;

namespace MaskedKiller.Model.Enemy.Decorators
{
	public class EnemyWithPickup : IEnemy
	{
		private readonly ISpreader _spreader;
		private readonly IHealth _health;
		private readonly IEnemy _enemy;

		private bool _visualized;

		public EnemyWithPickup(ISpreader pickupSpreader, IHealth health, IEnemy enemy)
		{
			_spreader = pickupSpreader ?? throw new ArgumentNullException(nameof(pickupSpreader));
			_health = health ?? throw new ArgumentNullException(nameof(health));
			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
		}

		public void Update(float deltaTime)
		{
			if (_health.IsDead && !_visualized)
			{
				_spreader.Use();
				_visualized = true;
			}
			
			_enemy.Update(deltaTime);
		}
	}
}
