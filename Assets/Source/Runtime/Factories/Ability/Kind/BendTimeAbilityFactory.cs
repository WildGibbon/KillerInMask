using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Model.Ability.Kind;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Ability
{
	public class BendTimeAbilityFactory : SerializedMonoBehaviour, IAbilityFactory
	{
		[SerializeField] private float _timeSlowCoefficient;
		
		public IAbility Create()
		{
			return new BendTimeAbility(_timeSlowCoefficient);
		}
	}
}