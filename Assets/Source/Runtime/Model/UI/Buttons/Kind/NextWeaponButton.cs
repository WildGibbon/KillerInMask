using MaskedKiller.Model.Character;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class NextWeaponButton : IButton
	{
		private readonly ICharacter _character;

		public NextWeaponButton(ICharacter charcater)
		{
			_character = charcater ?? throw new ArgumentNullException(nameof(charcater));
		}

		public void Press()
		{
			_character.SwitchNextWeapon();
		}
	}
}
