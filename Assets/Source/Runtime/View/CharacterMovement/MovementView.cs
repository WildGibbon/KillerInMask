using UnityEngine;

namespace MaskedKiller.View.Movement
{
	public class MovementView : MonoBehaviour, IMovementView
	{
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Visualize(Vector2 velocity)
		{
			_rigidbody.velocity = new Vector2(velocity.x, _rigidbody.velocity.y);
		}
	}
}
