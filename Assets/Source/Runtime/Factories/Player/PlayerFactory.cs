using MaskedKiller.Factories.Health;
using MaskedKiller.Model.Character;
using MaskedKiller.Model.Player;
using MaskedKiller.Model.Health;
using MaskedKiller.Model.Input;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Player
{
	public class PlayerFactory : SerializedMonoBehaviour, IPlayerFactory
	{
		[SerializeField] private IHealthFactory _playerHealthFactory;
		[SerializeField] private PhysicalHealth _physicalHealth;
		[SerializeField] private IMovementInput _movementInput;

		public IPlayer Create(ICharacter character)
		{
			var health = _playerHealthFactory.Create();
			_physicalHealth.Init(health);

			return new Model.Player.Player(_movementInput, character, health);
		}
	}
}