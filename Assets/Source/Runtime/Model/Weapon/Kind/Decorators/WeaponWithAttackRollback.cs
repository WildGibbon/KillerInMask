using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Model.Weapon
{
	public class WeaponWithAttackRollback : IWeapon
	{
		public bool CanAttack { get; private set; } = true;

		private readonly IWeapon _weapon;
		private readonly float _rollbackDelayInSeconds;

		public WeaponWithAttackRollback(IWeapon weapon, float rollbackDelayInSeconds)
		{
			if(rollbackDelayInSeconds < 0)
				throw new ArgumentOutOfRangeException(nameof(rollbackDelayInSeconds));

			_weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
			_rollbackDelayInSeconds = rollbackDelayInSeconds;
		}

		public void AttackIn(Vector2 direction)
		{
			if (!CanAttack)
				throw new InvalidOperationException();

			_weapon.AttackIn(direction);
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
