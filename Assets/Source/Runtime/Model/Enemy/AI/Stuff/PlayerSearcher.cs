using MaskedKiller.Factories.Player;
using System;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public class PlayerSearcher : IPlayerSearcher
	{
		public bool IsPlayerNear 
			=> Physics2D.OverlapCircle(_searcherTransform.position, _searchDistance)
			.TryGetComponent<IPlayerFactory>(out var player);
		
		private readonly Transform _searcherTransform;
		private readonly float _searchDistance;

		public PlayerSearcher(Transform searcherTransform, float searchDistance)
		{
			_searcherTransform = searcherTransform ?? throw new ArgumentNullException(nameof(searcherTransform));
			_searchDistance = searchDistance;
		}

		public Transform GetNearbyPlayerTransform()
		{
			if(!IsPlayerNear)
				throw new ArgumentNullException(nameof(IsPlayerNear));

			var playerCollider = Physics2D.OverlapCircle(_searcherTransform.position, _searchDistance);

			return playerCollider.GetComponent<Transform>();
		}
	}
}
