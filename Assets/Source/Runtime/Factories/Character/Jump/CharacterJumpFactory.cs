using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character.Jump;
using MaskedKiller.View.CharacterJump;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Character.Jump
{
	public class CharacterJumpFactory : SerializedMonoBehaviour, ICharacterJumpFactory
	{
		[SerializeField] private ISurfaceCollisionDetector _collisionDetector;
		[SerializeField] private float _jumpForce;

		public ICharacterJump Create(IViews views)
		{
			if (views == null)
				throw new ArgumentNullException(nameof(views));

			return new CharacterJump(_collisionDetector, views.CharacterJumpView, _jumpForce);
		}
	}
}
