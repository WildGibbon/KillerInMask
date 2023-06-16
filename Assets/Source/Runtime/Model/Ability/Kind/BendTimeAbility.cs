using UnityEngine;
using System;

namespace MaskedKiller.Model.Ability.Kind
{
	public class BendTimeAbility : IAbility
	{
		public bool CanUse { get; private set; } = true;

		private readonly float _bendTimeCoefficient;

		public BendTimeAbility(float bendTimeCoefficient)
		{
			if (bendTimeCoefficient <= 0 || bendTimeCoefficient >= 1)
				throw new ArgumentOutOfRangeException($"TimeSlowCoefficient must be less than 1 and more than 0");

			_bendTimeCoefficient = bendTimeCoefficient;
		}

		public void Use()
		{
			if(!CanUse)
				throw new InvalidOperationException();

			Time.timeScale = _bendTimeCoefficient;
			CanUse = false;
		}

		public void CancelUse()
		{
			Time.timeScale = 1f;
			CanUse = true;
		}
	}
}
