using MaskedKiller.Model.Enemy.Decorators;
using MaskedKiller.Factories.Health;
using MaskedKiller.Model.Health;
using MaskedKiller.Model.Enemy;
using MaskedKiller.View.Enemy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy
{
	public class DyingEnemyFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private PhysicalHealth _physicalHealth;
		[SerializeField] private IHealthFactory _healthFactory;
		[SerializeField] private IEnemyFactory _enemyFactory;
		[SerializeField] private IEnemyView _view; 

		public IEnemy Create()
		{
			var health = _healthFactory.Create();
			_physicalHealth.Init(health);

			return new DyingEnemy(_view, health, _enemyFactory.Create());
		}
	}
}
