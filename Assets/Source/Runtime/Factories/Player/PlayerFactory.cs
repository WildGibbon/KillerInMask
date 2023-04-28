using MaskedKiller.Model.UI.Buttons.Kind;
using MaskedKiller.Factories.Character;
using MaskedKiller.Factories.Selector;
using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Player;
using MaskedKiller.Model.Weapon;
using MaskedKiller.Model.Input;
using MaskedKiller.UI.Buttons;
using MaskedKiller.Game.Data;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Player
{
	public class PlayerFactory : SerializedMonoBehaviour, IPlayerFactory
	{
		[SerializeField] private ISelectorFactory<IWeapon> _weaponSelectorFactory;
		[SerializeField] private ICharacterFactory _characterFactory;
		[SerializeField] private IMovementInput _movementInput;

		public IPlayer Create(IGameData gameData)
		{
			var character = _characterFactory.Create(gameData.Views);
			var selector = _weaponSelectorFactory.Create();

			gameData.UI.Buttons.PreviousWeaponButton.Init(new PreviousSelectorItemButton<IWeapon>(selector));
			gameData.UI.Buttons.NextWeaponButton.Init(new NextSelectorItemButton<IWeapon>(selector));
			gameData.UI.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character, selector));
			gameData.UI.Buttons.JumpButton.Init(new CharacterJumpButton(character));

			return new Model.Player.Player(_movementInput, character);
		}
	}
}
