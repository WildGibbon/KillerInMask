using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Ability.Kind;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Ability
{
	public class BendTimeAbilityFactory : SerializedMonoBehaviour, IAbilityFactory
	{
		[SerializeField] private float _timeSlowCoefficient;
		[SerializeField] private float _abilityDuration;

		public IAbility Create()
		{
			return new BendTimeAbility(_timeSlowCoefficient, _abilityDuration);
		}
	}
}
