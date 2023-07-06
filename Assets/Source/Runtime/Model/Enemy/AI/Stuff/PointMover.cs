using MaskedKiller.Model.Character;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI
{
	//!BHUMAHUE!
	//максимально примитивная реализация 
	public class PointMover : IPointMover
	{
		public bool PointReached { get; private set; } = false;

		private readonly Transform _moverTransform;
		private readonly float _pointReachDistance;
		private readonly ICharacter _character;

		private Vector2 _targetPoint;

		public PointMover(Transform moverTransform, float pointReachDistance, ICharacter character)
		{
			if(_pointReachDistance < 0) 
				throw new ArgumentNullException(nameof(pointReachDistance));

			_moverTransform = moverTransform ?? throw new ArgumentNullException(nameof(moverTransform));
			_character = character ?? throw new ArgumentNullException(nameof(character));

			_pointReachDistance = pointReachDistance;
		}

		public void Set(Vector2 movePoint)
		{
			_targetPoint = movePoint;
			PointReached = false;
		}

		public void Update()
		{
			if (!PointReached)
			{
				if (_moverTransform.position.x - _targetPoint.x > 0)
					_character.Move(CharacterMoveDirection.Left);
				else
					_character.Move(CharacterMoveDirection.Right);

				if (Vector2.Distance(_targetPoint, _moverTransform.position) <= _pointReachDistance)
					PointReached = true;
			}
		}
	}
}
