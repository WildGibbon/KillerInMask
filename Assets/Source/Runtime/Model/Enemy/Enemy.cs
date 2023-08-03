using BananaParty.BehaviorTree;

namespace MaskedKiller.Model.Enemy
{
	public class Enemy : IEnemy
	{
		private readonly IBehaviorNode _behaviour;

		public Enemy(IBehaviorNode behaviorTreeRoot)
		{
			_behaviour = behaviorTreeRoot;
		}

		public void Update(float deltaTime)
		{
			if(_behaviour.Status > BehaviorNodeStatus.Running)
				_behaviour.Reset();

			_behaviour.Execute((long)deltaTime);
		}
	}
}
 