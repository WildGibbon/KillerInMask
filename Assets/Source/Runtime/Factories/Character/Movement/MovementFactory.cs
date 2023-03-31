using MaskedKiller.Model.Character.Movement;
using MaskedKiller.Game.Data.Views;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Character.Movement
{
	public class MovementFactory : SerializedMonoBehaviour, IMovementFactory
	{
		[SerializeField] private float _moveSpeed;

		private IViews _views;

		public ICharacterMovement Create()
		{
			return new CharacterMovement(_views.MovementView, _moveSpeed);
		}

		public void Init(IViews views)
		{
			_views = views ?? throw new ArgumentNullException(nameof(views));
		}
	}
}
