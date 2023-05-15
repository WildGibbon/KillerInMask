using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Factories.Ability;
using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Selector
{
	public class AbilitySelectorFactory : SerializedMonoBehaviour, ISelectorFactory<IAbility>
	{
		[SerializeField] private List<IAbilityFactory> _factories;

		public ISelector<IAbility> Create()
		{
			var abilities = new List<IAbility>();
			_factories.ForEach(factory => abilities.Add(factory.Create()));

			return new AbilitySelector(abilities);
		}
	}
}
