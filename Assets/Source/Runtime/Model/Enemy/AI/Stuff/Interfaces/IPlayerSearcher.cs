using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI.Stuff
{
	public interface IPlayerSearcher
	{
		bool IsPlayerNear { get; }
		Transform GetNearbyPlayerTransform();
	}
}
