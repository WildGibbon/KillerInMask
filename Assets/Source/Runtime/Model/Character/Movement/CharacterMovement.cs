using MaskedKiller.View.Movement;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Character.Movement
{
	public class CharacterMovement : ICharacterMovement
	{
		private readonly IMovementView _view;
		private readonly float _speed;

		public CharacterMovement(IMovementView view, float speed)
		{
			if(speed <= 0)
				throw new ArgumentOutOfRangeException(nameof(speed));

			_speed = speed;
			_view = view;
		}

		public void Move(Vector2 direction)
		{
			_view.Visualize(direction.normalized * _speed);
		}
	}
}
