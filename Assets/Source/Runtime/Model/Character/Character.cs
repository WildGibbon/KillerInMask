using MaskedKiller.Model.Movement;
using MaskedKiller.Model.Weapon;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Character
{
	public class Character : ICharacter
	{
		private readonly IWeaponSelector _selector;
		private readonly IMovement _movement;

		private Vector2 _playerViewDirection;

		public Character(IMovement movement, IWeaponSelector selector)
		{
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Move(MoveDirection direction)
		{
			var newDirection = new Vector2((int)direction, 0);
			_movement.Move(newDirection);

			_playerViewDirection = newDirection;
		}

		public void AttackWithWeapon()
		{
			_selector.CurrrentWeapon.AttackIn(_playerViewDirection);
		}
	}
}
