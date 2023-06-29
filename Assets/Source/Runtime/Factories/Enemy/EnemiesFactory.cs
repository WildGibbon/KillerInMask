using MaskedKiller.Model.Enemy;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaskedKiller.Factories.Enemy
{
	public class EnemiesFactory : MonoBehaviour, IEnemiesFactory
	{
		public IReadOnlyList<IEnemy> Create()
		{
			var enemies = new List<IEnemy>();

			GetComponentsInChildren<IEnemyFactory>().
				ToList<IEnemyFactory>().
				ForEach(factory => enemies.
				Add(factory.Create()));

			return enemies;
		}
	}
}
