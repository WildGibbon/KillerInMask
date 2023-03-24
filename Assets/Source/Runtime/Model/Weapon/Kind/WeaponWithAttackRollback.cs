using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Model.Weapon
{
	public class WeaponWithAttackRollback : IWeapon
	{
		public bool CanAttack { get; private set; }

		private readonly IWeapon _weapon;
		private readonly float _rollbackDelayInSeconds;

		public WeaponWithAttackRollback(IWeapon weapon)
		{
			_weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
		}

		public void AttackIn(Vector2 direction)
		{
			if (!CanAttack)
				throw new InvalidOperationException();

			_weapon.AttackIn(direction);

			if(CanAttack)
				StartRollback();
		}

		private async void StartRollback()
		{
			CanAttack = false;
			await UniTask.Delay(TimeSpan.FromSeconds(_rollbackDelayInSeconds));
			CanAttack = true;
		}
	}
}
