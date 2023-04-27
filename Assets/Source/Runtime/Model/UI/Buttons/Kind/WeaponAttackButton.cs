using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Character;
using MaskedKiller.Model.Selector;
using System;
using UnityEngine;

namespace MaskedKiller.UI.Buttons
{
	public class WeaponAttackButton : IButton
	{
		private readonly ICharacter _character;
		private readonly ISelector _selector;

		public WeaponAttackButton(ICharacter character, ISelector selector)
		{
			_character = character ?? throw new ArgumentNullException(nameof(character));
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_character.AttackWithWeapon(_selector.CurrrentItem);
		}
	}
}
