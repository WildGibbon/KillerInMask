using MaskedKiller.Factories.Character;
using MaskedKiller.Game.Data.UI;
using MaskedKiller.Model.Input;
using MaskedKiller.Model.Player;
using MaskedKiller.UI.Buttons;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Player
{
	public class PlayerFactory : SerializedMonoBehaviour, IPlayerFactory
	{
		[SerializeField] private ICharacterFactory _characterFactory;
		[SerializeField] private IMovementInput _movementInput;

		private IUIButtons _buttons;

		public IPlayer Create()
		{
			var character = _characterFactory.Create();
			_buttons.WeaponAttackButton.Init(new WeaponAttackButton(character));

			return new Model.Player.Player(_movementInput, character);
		}

		public void Init(IUIButtons uIButtons)
		{
			_buttons = uIButtons ?? throw new ArgumentNullException(nameof(uIButtons));
		}
	}
}
