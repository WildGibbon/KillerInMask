using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class IsPlayerVisibleNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;

		public override BehaviorNodeStatus OnExecute(long time)
		{
			
		}
	}
}
