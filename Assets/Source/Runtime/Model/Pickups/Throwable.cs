using MaskedKiller.Pickups.Interfaces;
using UnityEngine;

namespace MaskedKiller.Model.Pickups
{
	public class Throwable : MonoBehaviour, IThrowable
	{
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Throw(Vector2 velocity)
		{
			_rigidbody.AddForce(velocity);
		}
	}
}
