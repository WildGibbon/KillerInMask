using UnityEngine;
using System;

namespace MaskedKiller.Model.Character.Jump
{
	public class CharacterJump : ICharacterJump
	{
		public bool CanJump => true;

		private readonly Rigidbody2D _rigidbody;
		private readonly float _jumpForce;

		public CharacterJump(Rigidbody2D rigidbody, float jumpForce)
		{
			if (_jumpForce < 0)
				throw new ArgumentOutOfRangeException(nameof(jumpForce));

			_rigidbody = rigidbody ?? throw new ArgumentNullException(nameof(rigidbody));
			_jumpForce = jumpForce;
		}

		public void Jump()
		{
			if(!CanJump)
				throw new InvalidOperationException(nameof(Jump));

			_rigidbody.AddForce(_jumpForce * Vector2.up);
		}
	}
}
