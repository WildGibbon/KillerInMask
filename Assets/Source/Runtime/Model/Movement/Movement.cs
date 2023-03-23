using MaskedKiller.View.Movement;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Movement
{
	public class Movement : IMovement
	{
		private readonly IMovementView _view;
		private readonly float _speed;

		public Movement(IMovementView view, float speed)
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
