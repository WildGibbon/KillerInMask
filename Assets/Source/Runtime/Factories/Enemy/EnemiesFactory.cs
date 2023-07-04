using System.Collections.Generic;
using MaskedKiller.Model.Enemy;
using System.Linq;
using UnityEngine;
using Sirenix.OdinInspector;

namespace MaskedKiller.Factories.Enemy
{
	public class EnemiesFactory : SerializedMonoBehaviour, IEnemiesFactory
	{
		public IReadOnlyList<IEnemy> Create()
		{
			var enemies = new List<IEnemy>();

			GetComponentsInChildren<IEnemyFactory>()
				.ToList<IEnemyFactory>()
				.ForEach(factory => enemies.Add(factory.Create()));

			return enemies;
		}
	}
}
