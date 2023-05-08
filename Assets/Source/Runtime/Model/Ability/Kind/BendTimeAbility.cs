using Cysharp.Threading.Tasks;
using UnityEngine;
using System;
using MaskedKiller.Model.Ability.Mana;

namespace MaskedKiller.Model.Ability.Kind
{
	public class BendTimeAbility : IAbility
	{
		public bool CanUse { get; private set; } = true;

		private readonly float _timeSlowCoefficient;
		private readonly IManaStorage _manaStorage;
		private readonly float _abilityDuration;
		private readonly int _useCost;

		public BendTimeAbility(float timeSlowCoefficient, IManaStorage manaStorage, float abilityDuration, int useCost)
		{
			if (timeSlowCoefficient <= 0 || timeSlowCoefficient >= 1)
				throw new ArgumentOutOfRangeException($"TimeSlowCoefficient must be less than 1 and more than 0");
			if (abilityDuration <= 0)
				throw new ArgumentOutOfRangeException(nameof(abilityDuration));
			if(useCost < 0)
				throw new ArgumentOutOfRangeException(nameof(useCost));

			_manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));
			_timeSlowCoefficient = timeSlowCoefficient;
			_abilityDuration = abilityDuration;
			_useCost = useCost;
		}

		public void Use()
		{
			if(!CanUse)
				throw new InvalidOperationException();
			
			if(_manaStorage.CanTakeMana(_useCost))
				_manaStorage.TakeMana(_useCost);
			
			SlowTime();
		}

		private async void SlowTime()
		{
			CanUse = false;
			Time.timeScale = _timeSlowCoefficient;
			await UniTask.Delay(TimeSpan.FromSeconds(_abilityDuration));
			Time.timeScale = 1;
			CanUse = true;
		}
	}
}
