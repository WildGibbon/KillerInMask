using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Model.Input;
using MaskedKiller.Model.Movement;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly IMovementInput _movementInput;
		private readonly IMovement _movement;

		public Player(IMovementInput movementInput, IMovement movement)
		{
			_movementInput = movementInput ?? throw new ArgumentNullException(nameof(movementInput));
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
		}

		public void Update(float deltaTime)
		{
			if (_movementInput.IsMovingLeft)
				_movement.Move(Vector2.left);

			if(_movementInput.IsMovingRight)
				_movement.Move(Vector2.right);
		}
	}
}
