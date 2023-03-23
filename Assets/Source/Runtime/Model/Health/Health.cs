using System;
using MaskedKiller.View.Health;
using UnityEngine;

namespace MaskedKiller.Model.Health
{
	public class Health : IHealth
	{
		public int Value { get; private set; }
		public int MaxValue { get; private set; }
		public bool IsDead => Value <= 0;

		private readonly IHealthView _viev;

		public Health(IHealthView view, int value)
		{
			if (value <= 0)
				throw new ArgumentOutOfRangeException("Health value can not be less than 0");

			_viev = view ?? throw new ArgumentNullException(nameof(view));
			Value = MaxValue = value;
			_viev.Visualize(Value, MaxValue);
		}

		public void TakeDamage(int value)
		{
			if (IsDead)
				throw new InvalidOperationException("Can not take damage to dead health");

			if (value < 0)
				throw new ArgumentOutOfRangeException("Damage can not be less than 0");

			Value -= value;
			_viev.Visualize(Value, MaxValue);
		}

		public void Heal(int count)
		{
			if (count < 0)
				throw new ArgumentOutOfRangeException("Heal value can not be less than 0");

			if (IsDead)
				throw new InvalidOperationException("Can not heal dead health");

			if (Value + count > MaxValue)
			{
				Value = MaxValue;
				return;
			}

			Value += count;
			_viev.Visualize(Value, MaxValue);
		}

		public bool CanHeal(int count)
		{
			return Value + count <= MaxValue; 
		}
	}
}
