using MaskedKiller.Model.Character.Jump;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Character.Jump
{
	public class CharacterJumpFactory : SerializedMonoBehaviour, ICharacterJumpFactory
	{
		[SerializeField] private float _jumpForce;

		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public ICharacterJump Create()
		{
			return new CharacterJump(_rigidbody, _jumpForce);
		}
	}
}
