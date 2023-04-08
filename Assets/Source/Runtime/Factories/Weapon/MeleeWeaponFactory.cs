using MaskedKiller.Model.Attack;
using MaskedKiller.Model.Weapon;
using MaskedKiller.Model.Weapon.Kind;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class MeleeWeaponFactory : SerializedMonoBehaviour, IWeaponFactory
	{
		[SerializeField] private float _attackDistance;
		[SerializeField] private int _damage;

		public IWeapon Create()
		{
			return new MeleeWeapon(transform, _attackDistance, new DefaultAttack(_damage));
		}
	}
}
