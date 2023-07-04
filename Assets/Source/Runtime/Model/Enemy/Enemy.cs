using MaskedKiller.Model.Health;
using MaskedKiller.View.Enemy;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Enemy
{
	public class Enemy : IEnemy
	{
		private readonly IEnemyView _view;
		private readonly IHealth _health;

		private bool _visualized;

		public Enemy(IEnemyView view, IHealth health)
		{
			_view = view ?? throw new ArgumentNullException(nameof(view));
			_health = health ?? throw new ArgumentNullException(nameof(health));
		}

		public void Update(float deltaTime)
		{
			if (_health.IsDead && !_visualized)
			{
				_view.VisualizeDeath();
				_visualized = true;
			}
		}
	}
}
