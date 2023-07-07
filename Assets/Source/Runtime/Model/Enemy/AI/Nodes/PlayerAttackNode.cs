using MaskedKiller.Model.Enemy.AI.Stuff;
using BananaParty.BehaviorTree;
using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PlayerAttackNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;
		private readonly IWeapon _weapon;

		public override BehaviorNodeStatus OnExecute(long time)
		{
			_weapon.AttackIn(_playerSearcher.GetNearbyPlayerTransform().position);
		}
	}
}
