using MaskedKiller.Model.Enemy.AI.Nodes;
using MaskedKiller.Model.Enemy.AI;
using System.Collections.Generic;
using BananaParty.BehaviorTree;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Enemy.Decorators
{
	public class EnemyWithAttackerBehaviour : IEnemy
	{
		private readonly TextBehaviorTreeGraph _treeGraph;
		private readonly BehaviorNode _behaviour;
		private readonly IEnemy _enemy;

		public EnemyWithAttackerBehaviour(IReadOnlyList<Vector2> movePoints, IPointMover pointMover, IEnemy enemy)
		{
			_behaviour = new SelectorNode(new BehaviorNode[]
			{
				new SequenceNode(new IBehaviorNode[] 
				{
					new IsPlayerNearNode()
				}),

				new PatrolNode(movePoints, pointMover)
			}); 
				
			_treeGraph = new TextBehaviorTreeGraph("daun");
			_behaviour.WriteToGraph(_treeGraph);

			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
		}

		public void Update(float deltaTime)
		{
			_behaviour.Execute((long)deltaTime);
			_enemy.Update(deltaTime);

			
			Debug.Log(_treeGraph.ToString());
		}
	}
}
 