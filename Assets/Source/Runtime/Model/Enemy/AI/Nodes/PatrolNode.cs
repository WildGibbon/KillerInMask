using System;
using System.Collections.Generic;
using BananaParty.BehaviorTree;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PatrolNode : BehaviorNode
	{
		private readonly IReadOnlyList<Vector2> _patrolPoints;
		private readonly IPointMover _pointMover;
		
		private int _targetPointIndex = 0;

		public PatrolNode(IReadOnlyList<Vector2> patrolPoints, IPointMover pointMover)
		{
			_patrolPoints = patrolPoints ?? throw new ArgumentNullException(nameof(patrolPoints));
			_pointMover = pointMover ?? throw new ArgumentNullException(nameof(pointMover));

			_pointMover.Set(_patrolPoints[_targetPointIndex]);
		}

		public override BehaviorNodeStatus OnExecute(long time)
		{
			if(_pointMover.PointReached)
			{
				if (_targetPointIndex + 1 > _patrolPoints.Count - 1)
					_targetPointIndex = 0;
				else
					_targetPointIndex++;

				_pointMover.Set(_patrolPoints[_targetPointIndex]);
			}

			_pointMover.Update();

			return BehaviorNodeStatus.Running;
		}
	}
}