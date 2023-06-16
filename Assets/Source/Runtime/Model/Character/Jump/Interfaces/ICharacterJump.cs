using System;

namespace MaskedKiller.Model.Character.Jump
{
	public interface ICharacterJump
	{
		bool CanJump { get; }
		void Jump();
	}
}
