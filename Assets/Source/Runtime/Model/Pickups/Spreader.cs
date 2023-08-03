using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Factories.Pickups;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Pickups
{
	public class Spreader : MonoBehaviour, ISpreader
	{
		[SerializeField, Range(0, 360)] private float _maxAngle = 180;
		[SerializeField, Range(0, 360)] private float _minAngle = 0;
		[SerializeField, Range(0,999)] private int _spreadForce;

		private IThrowablesFactory _throwablesFactory;

		private void OnValidate()
		{
			if(_maxAngle < _minAngle)
				_maxAngle = _minAngle;
		}

		public void Use()
		{
			foreach (var throwable in _throwablesFactory.Create())
			{
				throwable.Throw(GetThrowDirection() * _spreadForce);
			}
		}

		public void Init(IThrowablesFactory factory)
			=> _throwablesFactory = factory ?? throw new ArgumentNullException(nameof(factory));

		private Vector2 GetThrowDirection()
		{
			var randomAngle = UnityEngine.Random.Range(_minAngle, _maxAngle) * Mathf.Deg2Rad;
			Debug.Log(randomAngle * Mathf.Rad2Deg);

			return new Vector2(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle) );
		}
	}
}
