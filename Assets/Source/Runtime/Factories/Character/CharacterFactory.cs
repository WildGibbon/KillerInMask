using MaskedKiller.Factories.Character.Movement;
using MaskedKiller.Factories.Character.Jump;
using MaskedKiller.Model.Character;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Character
{
	public class CharacterFactory : SerializedMonoBehaviour, ICharacterFactory
	{
		[SerializeField] private ICharacterJumpFactory _jumpFactory;
		[SerializeField] private IMovementFactory _movementFactory;

		public ICharacter Create()
		{
			return new Model.Character.Character(_movementFactory.Create(), _jumpFactory.Create());
		}
	}
}
