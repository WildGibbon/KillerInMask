using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Factories.Pickups;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Pickups
{
	public class RigidbodySpreader : MonoBehaviour, ISpreader
	{
		[SerializeField, Range(0, 360)] private float _minAngle = 0;
		[SerializeField, Range(0, 360)] private float _maxAngle = 180;
		[SerializeField, Range(0,999)] private int _spreadForce;
		[SerializeField] private IRigidbodies _rigidbodies;

		private void OnValidate()
		{
			if(_maxAngle > _minAngle)
				_maxAngle = _minAngle;
		}

		public void Use()
		{
			foreach (var pickupable in _rigidbodies.Get)
			{
				pickupable.GetComponent<Rigidbody2D>().AddForce(GetSpreadDirection() * _spreadForce);
			}
		}

		private Vector2 GetSpreadDirection()
		{
			return new Vector2
				(
				Mathf.Cos(UnityEngine.Random.Range(0, _maxAngle) * Mathf.Rad2Deg),
				Mathf.Sin(UnityEngine.Random.Range(0, _maxAngle) * Mathf.Rad2Deg)
				);
		}
	}
}
