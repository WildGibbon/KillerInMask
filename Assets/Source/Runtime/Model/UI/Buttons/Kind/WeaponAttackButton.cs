using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Character;
using MaskedKiller.Model.Selector;
using System;
using UnityEngine;
using MaskedKiller.Model.Weapon;

namespace MaskedKiller.UI.Buttons
{
	public class WeaponAttackButton : IButton
	{
		private readonly ISelector<IWeapon> _selector;
		private readonly ICharacter _character;

		public WeaponAttackButton(ICharacter character, ISelector<IWeapon> selector)
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
