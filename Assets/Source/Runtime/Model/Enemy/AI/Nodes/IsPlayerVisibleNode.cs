using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using System;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class IsPlayerVisibleNode : BehaviorNode
	{
		private readonly IEnemyVision _enemyVision;

		public IsPlayerVisibleNode(IEnemyVision enemyVision)
		{
			_enemyVision = enemyVision ?? throw new ArgumentNullException(nameof(enemyVision));
		}

		public override BehaviorNodeStatus OnExecute(long time)
			=> _enemyVision.IsPlayerVisible switch
			   {
				   false => BehaviorNodeStatus.Failure,
				   true => BehaviorNodeStatus.Success
			   };
	}
}
