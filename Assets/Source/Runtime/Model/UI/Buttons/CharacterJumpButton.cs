using MaskedKiller.Model.Character;
using MaskedKiller.Model.Character.Jump;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class CharacterJumpButton : IButton
	{
		private readonly ICharacter _character;

		public CharacterJumpButton(ICharacter character)
		{
			_character = character ?? throw new ArgumentNullException(nameof(character));
		}

		public void Press()
		{
			_character.Jump();
		}
	}
}
