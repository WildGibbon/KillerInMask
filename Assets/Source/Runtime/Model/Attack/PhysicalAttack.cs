using MaskedKiller.Model.Health;
using UnityEngine;

namespace MaskedKiller.Model.Attack
{
	public class PhysicalAttack : MonoBehaviour, IAttack
	{
		private IAttack _attack;

		public void Init(IAttack attack)
		{
			_attack = attack;
		}

		public void Attack(IHealth health)
		{
			_attack.Attack(health);
		}
	}
}
