using MaskedKiller.View.CharacterJump;
using System;

namespace MaskedKiller.Model.Character.Jump
{
	public class CharacterJump : ICharacterJump
	{
		public bool CanJump => _collisionDetector.IsActive;

		private readonly ISurfaceCollisionDetector _collisionDetector;
		private readonly ICharacterJumpView _view;
		private readonly float _jumpForce;

		public CharacterJump(ISurfaceCollisionDetector collisionDetector, ICharacterJumpView view, float jumpForce)
		{
			if (_jumpForce < 0)
				throw new ArgumentOutOfRangeException(nameof(jumpForce));

			_collisionDetector = collisionDetector ?? throw new ArgumentNullException(nameof(collisionDetector));
			_view = view ?? throw new ArgumentNullException(nameof(view));
			_jumpForce = jumpForce;
		}


		public void Jump()
		{
			if(!CanJump)
				throw new InvalidOperationException(nameof(Jump));

			_view.Visualize(_jumpForce);
		}
	}
}
