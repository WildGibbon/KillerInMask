using MaskedKiller.Model.Character;
using MaskedKiller.Model.UI.Buttons;
using System;

namespace MaskedKiller.UI.Buttons
{
	public class WeaponAttackButton : IButton
	{
		private readonly ICharacter _character;

		public WeaponAttackButton(ICharacter character)
		{
			_character = character ?? throw new ArgumentNullException(nameof(character));
		}

		public void Press()
		{
			_character.AttackWithWeapon();
		}
	}
}
