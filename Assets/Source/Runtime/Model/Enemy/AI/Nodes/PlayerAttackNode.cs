using MaskedKiller.Model.Enemy.AI.Stuff;
using MaskedKiller.Model.Weapon;
using BananaParty.BehaviorTree;
using System;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PlayerAttackNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;
		private readonly IWeapon _weapon;

		public PlayerAttackNode(IPlayerSearcher playerSearcher, IWeapon weapon)
		{
			_playerSearcher = playerSearcher ?? throw new ArgumentNullException(nameof(playerSearcher));
			_weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
		}

		public override BehaviorNodeStatus OnExecute(long time)
		{
			_weapon.AttackIn(_playerSearcher.GetPlayerTransform().position);
			return BehaviorNodeStatus.Success;
		}
	}
}
