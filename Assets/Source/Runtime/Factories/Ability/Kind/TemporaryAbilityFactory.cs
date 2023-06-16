using MaskedKiller.Model.Ability.Kind;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Ability.Kind
{
	public class TemporaryAbilityFactory : SerializedMonoBehaviour, IAbilityFactory
	{
		[SerializeField] private IAbilityFactory _abilityFactory;
		[SerializeField] private float _abilityDuration;

		public IAbility Create()
		{
			return new TemporaryAbility(_abilityDuration, _abilityFactory.Create());
		}
	}
}
