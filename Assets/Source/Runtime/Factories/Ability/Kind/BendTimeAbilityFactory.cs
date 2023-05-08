using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Model.Ability.Kind;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Ability
{
	public class BendTimeAbilityFactory : SerializedMonoBehaviour, IAbilityFactory
	{
		[SerializeField] private IManaStorageFactory _manaStorageFactory;
		[SerializeField] private float _timeSlowCoefficient;
		[SerializeField] private float _abilityDuration;
		[SerializeField] private int _abilityUseCost;
		
		public IAbility Create()
		{
			return new BendTimeAbility(_timeSlowCoefficient, _manaStorageFactory.Create(), _abilityDuration, _abilityUseCost);
		}
	}
}