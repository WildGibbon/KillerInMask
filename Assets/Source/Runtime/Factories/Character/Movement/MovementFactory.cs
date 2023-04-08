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

		public ICharacterMovement Create(IViews views)
		{
			if(views == null)
				throw new ArgumentNullException(nameof(views));

			return new CharacterMovement(views.MovementView, _moveSpeed);
		}
	}
}
