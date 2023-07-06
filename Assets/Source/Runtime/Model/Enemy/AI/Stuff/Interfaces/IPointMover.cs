using MaskedKiller.Game.SystemUpdates;
using UnityEngine;

namespace MaskedKiller.Model.Enemy.AI
{
	public interface IPointMover
	{
		bool PointReached { get; }
		void Set(Vector2 movePoint);
		void Update();
	}
}
