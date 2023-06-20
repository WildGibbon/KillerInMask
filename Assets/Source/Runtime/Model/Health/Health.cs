using System;
using MaskedKiller.View.Health;
using UnityEngine;

namespace MaskedKiller.Model.Health
{
	public class Health : IHealth
	{
		public bool IsDead => _value <= 0;

		private readonly IHealthView _view;
		private readonly int _maxValue;

		private int _value;

		public Health(IHealthView view, int value)
		{
			if (value <= 0)
				throw new ArgumentOutOfRangeException();

			_view = view ?? throw new ArgumentNullException(nameof(view));
			_value = _maxValue = value;
			
			_view.Visualize(_value, _maxValue);
		}

		public void TakeDamage(int value)
		{
			if (IsDead)
				throw new InvalidOperationException();
			if (value < 0)
				throw new ArgumentOutOfRangeException();

			_value -= value;
			_view.Visualize(_value, _maxValue);
		}

		public void Heal(int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException();
			if (IsDead)
				throw new InvalidOperationException();
			
			if (_value + count > _maxValue)
			{
				_value = _maxValue;
				return;
			}

			_value += count;
			_view.Visualize(_value, _maxValue);
		}
	}
}
