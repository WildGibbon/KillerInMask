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

		private ICharacter _instance; 

		public ICharacter Create()
		{
			if(_instance != null)
				return _instance;

			_instance = new Model.Character.Character(_movementFactory.Create(), _jumpFactory.Create());
			return _instance;
		}
	}
}
