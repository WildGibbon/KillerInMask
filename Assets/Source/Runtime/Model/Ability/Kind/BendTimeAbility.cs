﻿using Cysharp.Threading.Tasks;
using UnityEngine;
using System;

namespace MaskedKiller.Model.Ability.Kind
{
	public class BendTimeAbility : IAbility
	{
		public bool CanUse { get; private set; }

		private readonly float _timeSlowCoefficient;
		private readonly float _durationOfAbility;

		public BendTimeAbility(float timeSlowCoefficient, float durationOfAbility)
		{
			if (timeSlowCoefficient <= 0 || timeSlowCoefficient >= 1)
				throw new ArgumentOutOfRangeException($"TimeSlowCoefficient must be less than 1 and more than 0");
			if(durationOfAbility <= 0)
				throw new ArgumentOutOfRangeException(nameof(durationOfAbility));

			_timeSlowCoefficient = timeSlowCoefficient;
			_durationOfAbility = durationOfAbility;
		}


		public void Use()
		{
			if(!CanUse)
				throw new InvalidOperationException();

			SlowTime();
		}

		private async void SlowTime()
		{
			CanUse = false;
			Time.timeScale = _timeSlowCoefficient;
			await UniTask.Delay(TimeSpan.FromSeconds(_durationOfAbility));
			Time.timeScale = 1;
			CanUse = true;
		}
	}
}
