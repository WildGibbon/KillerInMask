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

		private IUI _ui;

		public IPlayer Create()
		{
			var character = _characterFactory.Create();
			_ui.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character));

			return new Model.Player.Player(_movementInput, character);
		}

		public void Init(IUI ui)
		{
			_ui = ui ?? throw new ArgumentNullException(nameof(ui));
		}
	}
}
