using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Model.Character;
using MaskedKiller.Model.Input;
using System;

namespace MaskedKiller.Model.Player
{
	public class Player : IPlayer
	{
		private readonly IMovementInput _movementInput;
		private readonly ICharacter _character;

		public Player(IMovementInput movementInput, ICharacter character)
		{
			_movementInput = movementInput ?? throw new ArgumentNullException(nameof(movementInput));
			_character = character ?? throw new ArgumentNullException(nameof(character));
		}

		public void Update(float deltaTime)
		{
			if (_movementInput.IsMovingLeft)
				_character.Move(MoveDirection.Left);

			if(_movementInput.IsMovingRight)
				_character.Move(MoveDirection.Right);
		}
	}
}
