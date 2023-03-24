using UnityEngine;

namespace MaskedKiller.Model.Weapon
{
	public interface IWeapon
	{
		void AttackIn(Vector2 direction);
		bool CanAttack { get; }
	}
}
