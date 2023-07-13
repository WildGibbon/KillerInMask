using MaskedKiller.Model.Enemy.Decorators;
using MaskedKiller.Model.Enemy.AI.Stuff;
using MaskedKiller.Factories.Enemy.AI;
using MaskedKiller.Factories.Weapon;
using System.Collections.Generic;
using MaskedKiller.Model.Enemy;
using Sirenix.OdinInspector;
using System.Linq;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy.Decorators
{
	public class EnemyWithPatrolBehaviourFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private IPointMoverFactory _pointMoverFactory;
		[SerializeField] private IWeaponFactory _weaponFactory;
		[SerializeField] private List<Transform> _patrolPoints;
		[SerializeField] private float _playerDetectDistance;
		[SerializeField] private IEnemyFactory _enemyFactory;

		public IEnemy Create()
		{
			var playerSearcher = new NearbyPlayerSearcher(transform, _playerDetectDistance);
			var playerDetector = new PlayerDetector(transform, _playerDetectDistance);
			var enemyVision = new EnemyVision(playerSearcher, transform);
			
			var points = new List<Vector2>();

			_patrolPoints.ForEach(point => points.Add(point.position));

			return new EnemyWithPatrolBehaviour
				(points, _pointMoverFactory.Create(),
				playerDetector, playerSearcher,
				enemyVision, _weaponFactory.Create(),
				_enemyFactory.Create());
		}
	}
}
