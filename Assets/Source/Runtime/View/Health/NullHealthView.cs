using UnityEngine;

namespace MaskedKiller.View.Health
{
	public class NullHealthView : MonoBehaviour, IHealthView
	{
		public void Visualize(int value, int maxValue) { }
	}
}
