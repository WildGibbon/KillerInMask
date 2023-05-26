using MaskedKiller.Factories.Weapon;
using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using MaskedKiller.View;
using UnityEngine;

namespace MaskedKiller.Factories.Selector
{
	public class WeaponWithSpriteSelectorFactory : SerializedMonoBehaviour, ISelectorFactory<IWeapon>
	{
		[SerializeField] private Dictionary<IWeaponFactory, Sprite> _weaponFactoriesAndImages;
		[SerializeField] private ISelectorView _view;

		public ISelector<IWeapon> Create()
		{
			var weaponWithImages = new List<ItemWithSprite<IWeapon>>();

			foreach (var keyValuePair in _weaponFactoriesAndImages)
			{
				weaponWithImages.Add(new ItemWithSprite<IWeapon>(keyValuePair.Key.Create(), keyValuePair.Value));
			}
			
			return new WeaponWithSpriteSelector(_view, weaponWithImages);
		}
	}
}
