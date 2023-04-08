using MaskedKiller.Model.Character;
using MaskedKiller.Model.Weapon;
using System;

namespace MaskedKiller.Model.UI.Buttons.Kind
{
	public class PreviousWeaponButton : IButton
	{
		private readonly ICharacter _character;

		public PreviousWeaponButton(ICharacter charcater)
		{
			_character = charcater ?? throw new ArgumentNullException(nameof(charcater));
		}

		public void Press()
		{
			_character.SwitchPreviousWeapon();
		}
	}
}
