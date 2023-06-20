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
		private readonly ICharacterJump _jump;

		private Vector2 _characterViewDirection;

		public Character(ICharacterMovement movement, ICharacterJump jump)
		{
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_jump = jump ?? throw new ArgumentNullException(nameof(jump));
		}

		public void Move(MoveDirection direction)
		{
			var viewDirection = new Vector2((int)direction, 0);
			_movement.Move(viewDirection);

			_characterViewDirection = viewDirection;
		}

		public void Jump()
		{
			if (_jump.CanJump)
				_jump.Jump();
		}

		public void AttackWithWeapon(IWeapon weapon)
		{
			if(weapon.CanAttack)
				weapon.AttackIn(_characterViewDirection);
		}
	}
}
