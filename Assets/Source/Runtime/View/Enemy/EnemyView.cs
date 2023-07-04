using UnityEngine;

namespace MaskedKiller.View.Enemy
{
	public class EnemyView : MonoBehaviour, IEnemyView
	{
		public void VisualizeDeath()
		{
			GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0.5f);
		}
	}
}
