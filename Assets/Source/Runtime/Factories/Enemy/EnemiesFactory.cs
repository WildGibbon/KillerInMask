using System.Collections.Generic;
using MaskedKiller.Model.Enemy;
using System.Linq;
using UnityEngine;
using Sirenix.OdinInspector;

namespace MaskedKiller.Factories.Enemy
{
	public class EnemiesFactory : SerializedMonoBehaviour, IEnemiesFactory
	{
		[SerializeField] private List<IEnemyFactory> _list;

		public IReadOnlyList<IEnemy> Create()
		{
			var enemies = new List<IEnemy>();;
			_list.ForEach(factory => enemies.Add(factory.Create()));

			return enemies;
		}
	}
}
 