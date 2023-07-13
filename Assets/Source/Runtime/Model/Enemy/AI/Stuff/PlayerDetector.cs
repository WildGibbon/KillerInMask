using MaskedKiller.Factories.Player;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public class PlayerDetector : IPlayerDetector
	{
		public bool IsPlayerNear
			=> Physics2D.OverlapCircle(_detectorTransform.position, _detectDistance)
			.TryGetComponent<IPlayerFactory>(out var player);

		private readonly Transform _detectorTransform;
		private readonly float _detectDistance;

		public PlayerDetector(Transform detectorTransform, float detectDistance)
		{
			if(detectDistance < 0)
				throw new ArgumentOutOfRangeException(nameof(detectDistance));

			_detectorTransform = detectorTransform ?? throw new ArgumentNullException(nameof(detectorTransform));
			_detectDistance = detectDistance;
		}
	}	
}
