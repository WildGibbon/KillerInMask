using MaskedKiller.Factories.Player;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public class NearbyPlayerSearcher : IPlayerSearcher
	{	
		private readonly Transform _searcherTransform;
		private readonly float _searchDistance;

		public NearbyPlayerSearcher(Transform searcherTransform, float searchDistance)
		{
			_searcherTransform = searcherTransform ?? throw new ArgumentNullException(nameof(searcherTransform));
			_searchDistance = searchDistance;
		}

		public Transform GetPlayerTransform()
		{
			var playerCollider = Physics2D.OverlapCircle(_searcherTransform.position, _searchDistance);

			return playerCollider.transform;
		}
	}
}
