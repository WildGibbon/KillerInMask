using System;
using UnityEngine;

namespace MaskedKiller.Model.Health
{
	public class PhysicalHealth : MonoBehaviour, IHealth
	{
		public bool IsDead => _health.IsDead;

		private IHealth _health;

		public void Heal(int value)
		{
			_health.Heal(value);
		}

		public void TakeDamage(int value)
		{
			_health.TakeDamage(value);
		}

		public void Init(IHealth health) 
			=> _health = health ?? throw new ArgumentNullException(nameof(health));
	}
}
