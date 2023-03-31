using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class WeaponWithAttackRollbackFactory : SerializedMonoBehaviour, IWeaponFactory
	{
		[SerializeField] private IWeaponFactory _weaponFactory;

		public IWeapon Create()
		{
			return new WeaponWithAttackRollback(_weaponFactory.Create());
		}
	}
}
