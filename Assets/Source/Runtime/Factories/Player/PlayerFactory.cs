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

		private IGameData _gameData;

		public IPlayer Create()
		{
			_characterFactory.Init(_gameData.Views);
			var character = _characterFactory.Create();

			_gameData.UI.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character));
			_gameData.UI.Buttons.JumpButton.Init(new CharacterJumpButton(character));

			return new Model.Player.Player(_movementInput, character);
		}

		public void Init(IGameData gameData)
		{
			_gameData = gameData ?? throw new ArgumentNullException(nameof(gameData));
		}
	}
}
