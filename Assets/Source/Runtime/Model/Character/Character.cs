using MaskedKiller.Model.Character.Movement;
using MaskedKiller.Model.Character.Jump;
using MaskedKiller.Model.Weapon;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Character
{
	public class Character : ICharacter
	{
		private readonly ICharacterMovement _movement;
		private readonly IWeaponSelector _selector;
		private readonly ICharacterJump _jump;

		private Vector2 _playerViewDirection;

		public Character(ICharacterMovement movement, IWeaponSelector selector, ICharacterJump jump)
		{
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
			_jump = jump ?? throw new ArgumentNullException(nameof(jump));
		}

		public void Move(MoveDirection direction)
		{
			var newDirection = new Vector2((int)direction, 0);
			_movement.Move(newDirection);

			_playerViewDirection = newDirection;
		}

		public void AttackWithWeapon()
		{
			_selector.CurrrentWeapon.AttackIn(_playerViewDirection);
		}

		public void Jump()
		{
			_jump.Jump();
		}
	}
}
