using System.Collections.Generic;
using MaskedKiller.Model.Ability;
using MaskedKiller.View;
using System;

namespace MaskedKiller.Model.Selector
{
	public class AbilityWithSpriteSelector : ISelector<IAbility>
	{
		public IAbility CurrrentItem => _currentItemWithSprite.Item;

		private readonly List<ItemWithSprite<IAbility>> _items;
		private ISelectorView _view;

		private ItemWithSprite<IAbility> _currentItemWithSprite => _items[_currentItemWithSpriteIndex];
		private int _currentItemWithSpriteIndex = 0;

		public AbilityWithSpriteSelector(ISelectorView view, List<ItemWithSprite<IAbility>> items)
		{
			_items = items ?? throw new ArgumentNullException(nameof(items));
			_view = view ?? throw new ArgumentNullException(nameof(view));

			_view.Visualize(_currentItemWithSprite.Sprite);
		}

		public void NextItem()
		{
			if (_currentItemWithSpriteIndex == _items.Count - 1)
				_currentItemWithSpriteIndex = 0;
			else
				_currentItemWithSpriteIndex++;

			_view.Visualize(_currentItemWithSprite.Sprite);
		}

		public void PreviousItem()
		{
			if (_currentItemWithSpriteIndex == 0)
				_currentItemWithSpriteIndex = _items.Count - 1;
			else
				_currentItemWithSpriteIndex--;

			_view.Visualize(_currentItemWithSprite.Sprite);
		}	
	}
}
