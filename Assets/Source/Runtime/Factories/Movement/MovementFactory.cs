using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Movement;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Movement
{
	public class MovementFactory : SerializedMonoBehaviour, IMovementFactory
	{
		[SerializeField] private float _moveSpeed;

		private IViews _views;

		public IMovement Create()
		{
			return new Model.Movement.Movement(_views.MovementView, _moveSpeed);
		}

		public void Init(IViews views)
		{
			_views = views ?? throw new ArgumentNullException(nameof(views));
		}
	}
}
