using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using System;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PlayerAttackNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;
		private readonly IPointAttacker _pointAttacker;

		public PlayerAttackNode(IPlayerSearcher playerSearcher, IPointAttacker pointAttacker)
		{
			_playerSearcher = playerSearcher ?? throw new ArgumentNullException(nameof(playerSearcher));
			_pointAttacker = pointAttacker ?? throw new ArgumentNullException(nameof(pointAttacker));
		}

		public override BehaviorNodeStatus OnExecute(long time)
		{
			_pointAttacker.Use(_playerSearcher.GetPlayerTransform().position);
		
			return BehaviorNodeStatus.Success;
		}
	}
}
