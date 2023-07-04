using System.Collections.Generic;
using BananaParty.BehaviorTree;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PatrolNode : BehaviorNode
	{
		private readonly List<Transform> _patrolPoints;


		private Transform _targetPoint;

		public override BehaviorNodeStatus OnExecute(long time)
		{
			
		}
	}
}