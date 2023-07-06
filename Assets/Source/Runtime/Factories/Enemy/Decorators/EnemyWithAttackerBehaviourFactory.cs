using MaskedKiller.Factories.Enemy.AI;
using MaskedKiller.Model.Enemy;
using MaskedKiller.Model.Enemy.Decorators;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy.Decorators
{
	public class EnemyWithAttackerBehaviourFactory : SerializedMonoBehaviour, IEnemyFactory
	{
		[SerializeField] private IPointMoverFactory _pointMoverFactory;
		[SerializeField] private IEnemyFactory _enemyFactory;
		[SerializeField] private List<Transform> _patrolPoints;

		public IEnemy Create()
		{
			var points = new List<Vector2>();
			//GetComponentsInChildren<Transform>().ToList()
			_patrolPoints.ForEach(point => points.Add(point.position));

			return new EnemyWithAttackerBehaviour(points, _pointMoverFactory.Create(), _enemyFactory.Create());
		}
	}
}
