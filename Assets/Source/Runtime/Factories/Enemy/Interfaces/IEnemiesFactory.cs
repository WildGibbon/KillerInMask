using System.Collections.Generic;
using MaskedKiller.Model.Enemy;

namespace MaskedKiller.Factories.Enemy
{
	public interface IEnemiesFactory
	{
		IReadOnlyList<IEnemy> Create();
	}
}
