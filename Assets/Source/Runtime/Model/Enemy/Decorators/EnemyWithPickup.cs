using MaskedKiller.Factories.Pickups;
using MaskedKiller.Model.Pickups;
using System.Collections.Generic;
using MaskedKiller.Model.Health;
using UnityEngine;
using System.Linq;
using System;

namespace MaskedKiller.Model.Enemy
{
	public class EnemyWithPickup : IEnemy
	{
		private readonly ISpreader _pickupSpreader;
		private readonly IHealth _health;
		private readonly IEnemy _enemy;

		private bool _visualized;

		public EnemyWithPickup(ISpreader pickupSpreader, IHealth health, IEnemy enemy)
		{
			_pickupSpreader = pickupSpreader ?? throw new ArgumentNullException(nameof(pickupSpreader));
			_health = health ?? throw new ArgumentNullException(nameof(health));
			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
		}

		public void Update(float deltaTime)
		{
			if (_health.IsDead && !_visualized)
			{
				_pickupSpreader.Use();
				_visualized = true;
				Debug.Log("huy");
			}
			
			_enemy.Update(deltaTime);
		}
	}
}
