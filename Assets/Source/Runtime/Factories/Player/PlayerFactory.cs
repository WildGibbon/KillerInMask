using MaskedKiller.Model.UI.Buttons.Kind;
using MaskedKiller.Factories.Character;
using MaskedKiller.Factories.Selector;
using MaskedKiller.Factories.Health;
using MaskedKiller.Model.UI.Buttons;
using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Character;
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
		[SerializeField] private IMovementInput _movementInput;

		public IPlayer Create(ICharacter character)
		{
			return new Model.Player.Player(_movementInput, character);
		}
	}
}