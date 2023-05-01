using MaskedKiller.Model.UI.Buttons.Kind;
using MaskedKiller.Factories.Character;
using MaskedKiller.Factories.Selector;
using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Ability;
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
		[SerializeField] private ISelectorFactory<IAbility> _abilitySelectorFactory;
		[SerializeField] private ISelectorFactory<IWeapon> _weaponSelectorFactory;
		[SerializeField] private ICharacterFactory _characterFactory;
		[SerializeField] private IMovementInput _movementInput;

		public IPlayer Create(IGameData gameData)
		{
			var character = _characterFactory.Create(gameData.Views);
			var abilitySelector = _abilitySelectorFactory.Create();
			var weaponSelector = _weaponSelectorFactory.Create();

			gameData.UI.Buttons.PreviousWeaponButton.Init(new SelectorPreviousItemButton<IWeapon>(weaponSelector));
			gameData.UI.Buttons.NextWeaponButton.Init(new NextNextItemButton<IWeapon>(weaponSelector));
			gameData.UI.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character, weaponSelector));

			gameData.UI.Buttons.PreviousWeaponButton.Init(new SelectorPreviousItemButton<IAbility>(abilitySelector));
			gameData.UI.Buttons.NextAbilityButton.Init(new NextNextItemButton<IAbility>(abilitySelector));
			gameData.UI.Buttons.AbilityUseButton.Init(new AbilityUseButton(abilitySelector));

			gameData.UI.Buttons.JumpButton.Init(new CharacterJumpButton(character));

			return new Model.Player.Player(_movementInput, character);
		}
	}
}
