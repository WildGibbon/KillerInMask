using MaskedKiller.Model.Attack;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Health
{
	public class AttackReciever : MonoBehaviour
	{
		private IHealth _health;

		public void Init(IHealth health)
		{
			_health = health ?? throw new ArgumentNullException(nameof(health));
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if(collision.gameObject.TryGetComponent<IAttack>(out var attack)) 
			{
				attack.ApplyTo(_health);
			}
		}
	}
}
