using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.View.Gun
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class BulletView : MonoBehaviour, IBulletView
	{
		[SerializeField] private Rigidbody2D _rigidbody;

		public void Visualize(Vector2 velocity, Quaternion rotation)
		{
			_rigidbody.AddForce(velocity);
			gameObject.transform.rotation = rotation;
		}
	}
}
