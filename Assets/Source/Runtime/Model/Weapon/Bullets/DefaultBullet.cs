using MaskedKiller.View.Gun;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Weapon
{
	public class DefaultBullet : IBullet
	{
		private readonly IBulletView _view;
		private readonly float _throwForce;

		public DefaultBullet(IBulletView view, float throwForce)
		{
			if(throwForce <= 0)
				throw new ArgumentOutOfRangeException(nameof(throwForce));

			_throwForce = throwForce;
			_view = view ?? throw new ArgumentNullException(nameof(view));
		}

		public void Throw(Vector2 direction)
		{
			var rotation = Quaternion.LookRotation(Vector3.forward, direction);
			_view.Visualize(direction * _throwForce, rotation);
		}
	}
}