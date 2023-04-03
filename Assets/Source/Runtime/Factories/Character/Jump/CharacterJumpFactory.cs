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

		private IViews _views;

		public ICharacterJump Create()
		{
			return new CharacterJump(_collisionDetector, _views.CharacterJumpView, _jumpForce);
		}

		public void Init(IViews views)
		{
			_views = views ?? throw new ArgumentNullException(nameof(views));
		}
	}
}
