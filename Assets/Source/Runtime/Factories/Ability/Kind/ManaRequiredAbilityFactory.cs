using MaskedKiller.Model.Ability.Kind;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;
using MaskedKiller.Factories.Ability.Mana;

namespace MaskedKiller.Factories.Ability.Kind
{
	public class ManaRequiredAbilityFactory : SerializedMonoBehaviour, IAbilityFactory
	{
		[SerializeField] private IManaStorageFactory _manaStorageFactory;
		[SerializeField] private IAbilityFactory _abilityFactory;
		[SerializeField] private int _abilityUseCost;

		public IAbility Create()
		{
			return new ManaRequiredAbility(_manaStorageFactory.Create(), _abilityFactory.Create(), _abilityUseCost);
		}
	}
}
