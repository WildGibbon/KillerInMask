using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class IsPlayerNearNode : BehaviorNode
	{
		private readonly IPlayerDetector _playerDetector;

		public IsPlayerNearNode(IPlayerDetector playerDetector)
		{
			_playerDetector = playerDetector ?? throw new ArgumentNullException(nameof(playerDetector));
		}

		public override BehaviorNodeStatus OnExecute(long time)
		{
			return _playerDetector.IsPlayerNear switch
			{
				false => BehaviorNodeStatus.Failure,
				true => BehaviorNodeStatus.Success
			};
		}
	}
}
