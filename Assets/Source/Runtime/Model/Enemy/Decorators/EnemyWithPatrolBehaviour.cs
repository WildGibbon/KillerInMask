﻿using MaskedKiller.Model.Enemy.AI.Nodes;
using MaskedKiller.Model.Enemy.AI;
using System.Collections.Generic;
using MaskedKiller.Model.Enemy.AI.Stuff;
using MaskedKiller.Model.Weapon;
using BananaParty.BehaviorTree;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace MaskedKiller.Model.Enemy.Decorators
{
	public class EnemyWithPatrolBehaviour : IEnemy
	{
		private readonly TextBehaviorTreeGraph _treeGraph;
		private readonly BehaviorNode _behaviour;
		private readonly IEnemy _enemy;

		public EnemyWithPatrolBehaviour(IReadOnlyList<Vector2> movePoints,
			IPointMover pointMover, IPlayerDetector playerDetector,
			IPlayerSearcher playerSearcher, IEnemyVision vision,
			IWeapon weapon, IEnemy enemy)
		{
			_behaviour = new SelectorNode(new BehaviorNode[]
			{
				new SequenceNode(new BehaviorNode[] 
				{
					new IsPlayerNearNode(playerDetector),
					new IsPlayerVisibleNode(vision),
					new PlayerAttackNode(playerSearcher, weapon)
				}),

				new PatrolNode(movePoints, pointMover)
			});

			_enemy = enemy ?? throw new ArgumentNullException(nameof(enemy));
			_treeGraph = new TextBehaviorTreeGraph("pidr");
		}

		public void Update(float deltaTime)
		{
			_behaviour.Execute((long)deltaTime);
			_enemy.Update(deltaTime);

			_behaviour.WriteToGraph(_treeGraph);
			Debug.Log(_treeGraph.ToString());
		}
	}
}
 