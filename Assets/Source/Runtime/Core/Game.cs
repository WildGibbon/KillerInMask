using MaskedKiller.Model.UI.Buttons.Kind;
using MaskedKiller.Factories.Character;
using MaskedKiller.Factories.Selector;
using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Factories.Player;
using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Factories.Enemy;
using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Weapon;
using MaskedKiller.Game.Data.UI;
using MaskedKiller.Model.Enemy;
using MaskedKiller.UI.Buttons;
using Sirenix.OdinInspector;
using UnityEngine;
using System.Linq;

namespace MaskedKiller.Game
{
	public class Game : SerializedMonoBehaviour, IGame
	{
		[SerializeField] private ISelectorFactory<IAbility> _abilitySelectorFactory;
		[SerializeField] private ISelectorFactory<IWeapon> _weaponSelectorFactory;
		[SerializeField] private ICharacterFactory _characterFactory;
		[SerializeField] private IEnemiesFactory _enemiesFactory;
		[SerializeField] private IPlayerFactory _playerFactory;
		[SerializeField] private IUI _ui;

		private ISystemUpdate _systemUpdates;

		public void Play()
		{
			var abilitySelector = _abilitySelectorFactory.Create();
			var weaponSelector = _weaponSelectorFactory.Create();
			var character = _characterFactory.Create();

			_ui.Buttons.PreviousWeaponButton.Init(new PreviousItemButton<IWeapon>(weaponSelector));
			_ui.Buttons.NextWeaponButton.Init(new NextItemButton<IWeapon>(weaponSelector));
			_ui.Buttons.WeaponAttackButton.Init(new WeaponAttackButton(character, weaponSelector));

			_ui.Buttons.PreviousAbilityButton.Init(new PreviousItemButton<IAbility>(abilitySelector));
			_ui.Buttons.NextAbilityButton.Init(new NextItemButton<IAbility>(abilitySelector));
			_ui.Buttons.AbilityUseButton.Init(new AbilityUseButton(abilitySelector));

			_ui.Buttons.JumpButton.Init(new CharacterJumpButton(character));

			_systemUpdates = new SystemUpdate();

			Debug.Log(_enemiesFactory.Create().ToArray<IEnemy>());

			_systemUpdates.Add(_enemiesFactory.Create().ToArray<IEnemy>());
			_systemUpdates.Add(_playerFactory.Create(character));
		}

		private void Update()
		{
			_systemUpdates.UpdateAll(Time.deltaTime);
		}
	}
}
