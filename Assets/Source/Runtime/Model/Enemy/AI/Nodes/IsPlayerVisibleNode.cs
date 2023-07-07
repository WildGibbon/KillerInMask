using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class IsPlayerVisibleNode : BehaviorNode
	{
		private readonly IEnemyVision _enemyVision;

		public override BehaviorNodeStatus OnExecute(long time)
			=> _enemyVision.IsPlayerVisible switch
			   {
				   false => BehaviorNodeStatus.Failure,
				   true => BehaviorNodeStatus.Success
			   };
	}
}
