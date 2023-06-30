using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Model.Character;
using MaskedKiller.Model.Health;
using MaskedKiller.Model.Input;
using System;

namespace MaskedKiller.Model.Player
{
	public class Player : IPlayer
	{
		private readonly IMovementInput _movementInput;
		private readonly ICharacter _character;
		private readonly IHealth _playerHealth;

		public Player(IMovementInput movementInput, ICharacter character, IHealth playerHealth)
		{
			_movementInput = movementInput ?? throw new ArgumentNullException(nameof(movementInput));
			_playerHealth = playerHealth ?? throw new ArgumentNullException(nameof(playerHealth));
			_character = character ?? throw new ArgumentNullException(nameof(character));
		}

		public void Update(float deltaTime)
		{
			if (_movementInput.IsMovingLeft)
				_character.Move(CharacterMoveDirection.Left);

			if(_movementInput.IsMovingRight)
				_character.Move(CharacterMoveDirection.Right);
		}
	}
}
