using MaskedKiller.Factories.Health;
using MaskedKiller.Model.Enemy;
using MaskedKiller.View.Enemy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy
{
	public class EnemyFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private IHealthFactory _healthFactory;
		[SerializeField] private IEnemyView _view; 

		public IEnemy Create()
		{
			return new Model.Enemy.Enemy(_view, _healthFactory.Create());
		}
	}
}
