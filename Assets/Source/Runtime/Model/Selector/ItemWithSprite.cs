using System;
using UnityEngine;

namespace MaskedKiller.Model.Selector
{
	public struct ItemWithSprite<T>
	{
		public readonly T Item;
		public readonly Sprite Sprite;

		public ItemWithSprite(T item, Sprite sprite)
		{
			Sprite = sprite ?? throw new ArgumentNullException(nameof(sprite));
			Item = item ?? throw new ArgumentNullException(nameof(item));
		}
	}
}
