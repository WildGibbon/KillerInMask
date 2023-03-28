using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character;
using Sirenix.OdinInspector;
using UnityEngine;
using System;
using MaskedKiller.Factories.Movement;
using MaskedKiller.Factories.Weapon;

namespace MaskedKiller.Factories.Character
{
	public class CharacterFactory : SerializedMonoBehaviour, ICharacterFactory
	{
		[SerializeField] private IWeaponSelectorFactory _selectorFactory;
		[SerializeField] private IMovementFactory _movementFactory;

		public ICharacter Create()
		{
			return new Model.Character.Character(_movementFactory.Create(), _selectorFactory.Create());
		}

		public void Init(IViews views)
		{
			if(views == null)
				throw new ArgumentNullException(nameof(views));

			_movementFactory.Init(views);
		}
	}
}
