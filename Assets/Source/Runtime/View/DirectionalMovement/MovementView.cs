using UnityEngine;

namespace MaskedKiller.View.Movement
{
	public class MovementView : MonoBehaviour, IMovementView
	{
		public void Visualize(Vector2 velocity)
		{
			GetComponent<Rigidbody2D>().velocity = velocity;
		}
	}
}
