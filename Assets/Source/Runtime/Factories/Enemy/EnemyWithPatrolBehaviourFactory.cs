using MaskedKiller.Model.Enemy.AI.Nodes;
using MaskedKiller.Model.Enemy.AI.Stuff;
using MaskedKiller.Factories.Enemy.AI;
using MaskedKiller.Factories.Weapon;
using System.Collections.Generic;
using MaskedKiller.Model.Enemy;
using BananaParty.BehaviorTree;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy.Decorators
{
	public class EnemyWithPatrolBehaviourFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private IPointMoverFactory _pointMoverFactory;
		[SerializeField] private IWeaponFactory _weaponFactory;
		[SerializeField] private List<Transform> _patrolPoints;
		[SerializeField] private float _playerDetectDistance;
		[SerializeField] private Transform _weaponTransform;

		public IEnemy Create()
		{
			var pointAttacker = new PointAttacker(_weaponTransform, _weaponFactory.Create());
			var playerSearcher = new NearbyPlayerSearcher(transform, _playerDetectDistance);
			var playerDetector = new PlayerDetector(transform, _playerDetectDistance);
			var enemyVision = new EnemyVision(playerSearcher, transform);
			
			var points = new List<Vector2>();
			_patrolPoints.ForEach(point => points.Add(point.position));

			var behaviourRoot = new SelectorNode(new BehaviorNode[]
			{
				new SequenceNode(new BehaviorNode[]
				{
					new IsPlayerNearNode(playerDetector),
					new IsPlayerVisibleNode(enemyVision),
					new PlayerAttackNode(playerSearcher, pointAttacker)
				}),

				new PatrolNode(points, _pointMoverFactory.Create())
			});

			return new Model.Enemy.Enemy(behaviourRoot);
		}
	}
}
