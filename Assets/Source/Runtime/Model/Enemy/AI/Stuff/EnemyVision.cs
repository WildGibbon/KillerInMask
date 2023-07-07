using System;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public class EnemyVision : IEnemyVision
	{
		private readonly IPlayerSearcher _playerSearcher;
		private readonly Transform _visionTransform;

		public EnemyVision(IPlayerSearcher playerSearcher, Transform visionTransform)
		{
			_visionTransform = visionTransform ?? throw new ArgumentNullException(nameof(visionTransform));
			_playerSearcher = playerSearcher ?? throw new ArgumentNullException(nameof(playerSearcher));
		}

		public bool IsPlayerVisible
		{
			get
			{
				if (!_playerSearcher.IsPlayerNear)
					return false;

				return Physics2D.Raycast(_visionTransform.position, _playerSearcher.GetNearbyPlayerTransform().position);
			}
		}
	}
}
