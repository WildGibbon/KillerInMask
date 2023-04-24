using MaskedKiller.Model.UI.Buttons.Kind;
using MaskedKiller.Factories.Character;
using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Player;
using MaskedKiller.Model.Input;
using MaskedKiller.UI.Buttons;
using MaskedKiller.Game.Data;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Player
{
	public class PlayerFactory : SerializedMonoBehaviour, IPlayerFactory
	{
		[SerializeField] private ICharacterFactory _characterFactory;
		[SerializeField] private IMovementInput _movementInput;

		public IPlayer Create(IGameData gameData)
		{
			var character = _characterFactory.Create(gameData.Views);

			gameData.UI.Buttons.PreviousWeaponButton.Init(new PreviousWeaponButton(character));
			gameData.UI.Buttons.NextWeaponButton.Init(new NextWeaponButton(character));

			gameData.UI.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character));
			gameData.UI.Buttons.JumpButton.Init(new CharacterJumpButton(character));

			return new Model.Player.Player(_movementInput, character);
		}
	}
}
