using UnityEngine;

namespace MaskedKiller.View.Enemy
{
	public class EnemyView : MonoBehaviour, IEnemyView
	{
		public void VisualizeDeath()
		{
			Destroy(gameObject);
		}
	}
}
