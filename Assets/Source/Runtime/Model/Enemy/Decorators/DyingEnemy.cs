using MaskedKiller.Model.Health;
using MaskedKiller.View.Enemy;
using System;

namespace MaskedKiller.Model.Enemy.Decorators
{
	public class DyingEnemy : IEnemy
	{
		private readonly IEnemyView _view;
		private readonly IHealth _health;
		private readonly IEnemy _enemy;

		private bool _visualized;

		public DyingEnemy(IEnemyView view, IHealth health, IEnemy enemy)
		{
			_health = health ?? throw new ArgumentNullException(nameof(health));
			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
			_view = view ?? throw new ArgumentNullException(nameof(view));
		}

		public void Update(float deltaTime)
		{
			if (_health.IsDead && !_visualized)
			{
				_view.VisualizeDeath();
				_visualized = true;
			}

			_enemy.Update(deltaTime);
		}
	}
}
