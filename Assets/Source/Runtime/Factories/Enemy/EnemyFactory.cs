using MaskedKiller.Factories.Health;
using MaskedKiller.Model.Enemy;
using MaskedKiller.Model.Health;
using MaskedKiller.View.Enemy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy
{
	public class EnemyFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private PhysicalHealth _physicalHealth;
		[SerializeField] private IHealthFactory _healthFactory;
		[SerializeField] private IEnemyView _view; 

		public IEnemy Create()
		{
			var health = _healthFactory.Create();
			_physicalHealth.Init(health);

			return new Model.Enemy.Enemy(_view, health);
		}
	}
}
