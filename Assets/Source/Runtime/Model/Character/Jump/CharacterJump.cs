using MaskedKiller.View.CharacterJump;
using System;

namespace MaskedKiller.Model.Character.Jump
{
	public class CharacterJump : ICharacterJump
	{
		public bool CanJump => true;

		private readonly ICharacterJumpView _view;
		private readonly float _jumpForce;

		public CharacterJump(ICharacterJumpView view, float jumpForce)
		{
			if (_jumpForce < 0)
				throw new ArgumentOutOfRangeException(nameof(jumpForce));

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
