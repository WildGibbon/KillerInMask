using MaskedKiller.Model.Health;
using UnityEngine;

namespace MaskedKiller.Model.Attack
{
	public class PhysicalAttack : MonoBehaviour
	{
		private IAttack _attack;

		public void Init(IAttack attack)
		{
			_attack = attack;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.transform.TryGetComponent<IHealth>(out var health))
				_attack.ApplyTo(health);
		}
	}
}
