using MaskedKiller.Factories.Character;
using MaskedKiller.Model.Enemy.AI;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy.AI
{
	public class PointMoverFactory : SerializedMonoBehaviour, IPointMoverFactory
	{
		[SerializeField] private float _pointReachingDistance;
		[SerializeField] private ICharacterFactory _factory;

		public IPointMover Create()
		{
			return new PointMover(transform, _pointReachingDistance, _factory.Create());
		}
	}
}
