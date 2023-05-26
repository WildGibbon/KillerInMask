using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Factories.Ability;
using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using MaskedKiller.Model.Ability;
using Sirenix.OdinInspector;
using UnityEngine;
using MaskedKiller.View;
using MaskedKiller.Factories.Weapon;
using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Factories.Selector
{
	public class AbilityWithSpriteSelectorFactory : SerializedMonoBehaviour, ISelectorFactory<IAbility>
	{
		[SerializeField] private Dictionary<IAbilityFactory, Sprite> _factoriesWithSprites;
		[SerializeField] private ISelectorView _view;

		public ISelector<IAbility> Create()
		{
			var itemsWithSprites = new List<ItemWithSprite<IAbility>>();

			foreach (var keyValuePair in _factoriesWithSprites)
			{
				itemsWithSprites.Add(new ItemWithSprite<IAbility>(keyValuePair.Key.Create(), keyValuePair.Value));
			}

			return new AbilityWithSpriteSelector(_view, itemsWithSprites);
		}
	}
}
