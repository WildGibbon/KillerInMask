using MaskedKiller.Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Factories.Weapon
{
	public class WeaponWithAttackRollbackFactory : IWeaponFactory
	{
		[SerializeField] private IWeaponFactory _weaponFactory;

		public IWeapon Create()
		{
			return new WeaponWithAttackRollback(_weaponFactory.Create());
		}
	}
}
