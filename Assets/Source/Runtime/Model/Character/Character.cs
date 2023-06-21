using MaskedKiller.Model.Character.Movement;
using MaskedKiller.Model.Character.Jump;
using MaskedKiller.Model.Weapon;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Character
{
	public class Character : ICharacter
	{
		public Vector2 ViewDirection { get; private set; }
		
		private readonly ICharacterMovement _movement;
		private readonly ICharacterJump _jump;

		public Character(ICharacterMovement movement, ICharacterJump jump)
		{
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_jump = jump ?? throw new ArgumentNullException(nameof(jump));
		}

		public void Move(CharacterMoveDirection direction)
		{
			ViewDirection = new Vector2((int)direction, 0);
			_movement.Move(ViewDirection);
		}

		public void Jump()
		{
			if (_jump.CanJump)
				_jump.Jump();
		}
	}
}
