using MaskedKiller.Model.Character.Movement;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Character.Movement
{
	public class MovementFactory : SerializedMonoBehaviour, IMovementFactory
	{
		[SerializeField] private float _moveSpeed;

		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public ICharacterMovement Create()
		{
			return new CharacterMovement(_rigidbody, _moveSpeed);
		}
	}
}
