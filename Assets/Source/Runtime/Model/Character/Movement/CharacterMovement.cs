using UnityEngine;
using System;

namespace MaskedKiller.Model.Character.Movement
{
	public class CharacterMovement : ICharacterMovement
	{
		private readonly Rigidbody2D _rigidbody;
		private readonly float _speed;

		public CharacterMovement(Rigidbody2D rigidbody, float speed)
		{
			if(speed <= 0)
				throw new ArgumentOutOfRangeException(nameof(speed));

			_rigidbody = rigidbody ?? throw new ArgumentNullException(nameof(rigidbody));
			_speed = speed;
		}

		public void Move(Vector2 direction)
		{
			_rigidbody.AddForce(direction.normalized * _speed);
		}
	}
}
