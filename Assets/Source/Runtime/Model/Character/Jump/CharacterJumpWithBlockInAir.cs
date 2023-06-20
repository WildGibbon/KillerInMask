using System;

namespace MaskedKiller.Model.Character.Jump
{
	public class CharacterJumpWithBlockInAir : ICharacterJump
	{
		public bool CanJump => _jump.CanJump && _surfaceDetector.IsActive;

		private readonly ISurfaceDetector _surfaceDetector;
		private readonly ICharacterJump _jump;

		public CharacterJumpWithBlockInAir(ISurfaceDetector surfaceDetector, ICharacterJump jump)
		{
			_surfaceDetector = surfaceDetector ?? throw new ArgumentNullException(nameof(surfaceDetector));
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
