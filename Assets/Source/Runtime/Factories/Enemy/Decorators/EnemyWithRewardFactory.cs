using MaskedKiller.Factories.Pickups;
using MaskedKiller.Factories.Health;
using MaskedKiller.Model.Pickups;
using System.Collections.Generic;
using MaskedKiller.Model.Health;
using MaskedKiller.Model.Enemy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy.Decorators
{
	public class EnemyWithRewardFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private IEnemyFactory _enemyFactory;
		[SerializeField] private IThrowablesFactory _factory;
		[SerializeField] private IHealthFactory _health;
		[SerializeField] private ISpreader _spreader;

		private List<Rigidbody2D> _rigidbodies;

		public IEnemy Create()
		{
			_spreader.Init(_factory);

			return new EnemyWithPickup(_spreader, _health.Create(), _enemyFactory.Create());
		}
	}
}
