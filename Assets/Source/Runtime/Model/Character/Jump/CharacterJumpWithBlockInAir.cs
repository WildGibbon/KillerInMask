using System;

namespace MaskedKiller.Model.Character.Jump
{
	public class CharacterJumpWithBlockInAir : ICharacterJump
	{
		public bool CanJump => _jump.CanJump && _collisionDetector.IsActive;

		private readonly ISurfaceCollisionDetector _collisionDetector;
		private readonly ICharacterJump _jump;

		public CharacterJumpWithBlockInAir(ISurfaceCollisionDetector collisionDetector, ICharacterJump jump)
		{
			_collisionDetector = collisionDetector ?? throw new ArgumentNullException(nameof(collisionDetector));
			_jump = jump ?? throw new ArgumentNullException(nameof(jump));
		}

		public void Jump()
		{
			if (!CanJump)
				throw new InvalidOperationException();

			_jump.Jump();
		}
	}
}
