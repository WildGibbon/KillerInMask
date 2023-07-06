using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using System;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class IsPlayerNearNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;

		public IsPlayerNearNode(IPlayerSearcher playerDetector)
		{
			_playerSearcher = playerDetector ?? throw new ArgumentNullException(nameof(playerDetector));
		}

		public override BehaviorNodeStatus OnExecute(long time)
			=> _playerSearcher.IsPlayerNear switch
				{ 
					false => BehaviorNodeStatus.Failure,
					true => BehaviorNodeStatus.Success
				};
	}
}
