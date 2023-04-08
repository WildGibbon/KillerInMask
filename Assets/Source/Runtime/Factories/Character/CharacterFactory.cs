using MaskedKiller.Factories.Character.Movement;
using MaskedKiller.Factories.Character.Jump;
using MaskedKiller.Factories.Weapon;
using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Character
{
	public class CharacterFactory : SerializedMonoBehaviour, ICharacterFactory
	{
		[SerializeField] private IWeaponSelectorFactory _selectorFactory;
		[SerializeField] private ICharacterJumpFactory _jumpFactory;
		[SerializeField] private IMovementFactory _movementFactory;

		public ICharacter Create(IViews views)
		{
			if(views == null)
				throw new ArgumentNullException(nameof(views));

			return new Model.Character.Character(_movementFactory.Create(views), _selectorFactory.Create(), _jumpFactory.Create(views));
		}
	}
}
