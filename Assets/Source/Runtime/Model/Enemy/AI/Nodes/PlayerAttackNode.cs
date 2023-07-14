using MaskedKiller.Model.Enemy.AI.Stuff;
using MaskedKiller.Model.Weapon;
using BananaParty.BehaviorTree;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Nodes
{
	public class PlayerAttackNode : BehaviorNode
	{
		private readonly IPlayerSearcher _playerSearcher;
		private readonly Transform _attackerTransform;
		private readonly IWeapon _weapon;

		public PlayerAttackNode(IPlayerSearcher playerSearcher, Transform attackerTransform, IWeapon weapon)
		{
			_attackerTransform = attackerTransform ?? throw new ArgumentNullException(nameof(attackerTransform));
			_playerSearcher = playerSearcher ?? throw new ArgumentNullException(nameof(playerSearcher));
			_weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
		}

		public override BehaviorNodeStatus OnExecute(long time)
		{
			var attackDirection = _playerSearcher.GetPlayerTransform().position - _attackerTransform.position;

			if(_weapon.CanAttack)
				_weapon.AttackIn(attackDirection);
		
			return BehaviorNodeStatus.Success;
		}
	}
}
