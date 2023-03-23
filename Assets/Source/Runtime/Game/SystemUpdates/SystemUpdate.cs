using System.Collections.Generic;

namespace MaskedKiller.Game.SystemUpdates
{
	public class SystemUpdate : ISystemUpdate
	{
		private readonly List<IUpdatable> _updatables;

		public SystemUpdate()
		{
			_updatables = new List<IUpdatable>();
		}

		public void Add(params IUpdatable[] updatables)
		{
			_updatables.AddRange(updatables);
		}

		public void UpdateAll(float deltaTime)
		{
			_updatables.ForEach(updatable => updatable.Update(deltaTime));
		}
	}
}
