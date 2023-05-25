using MaskedKiller.Factories.Weapon;
using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using MaskedKiller.Model.Weapon;
using Sirenix.OdinInspector;
using UnityEngine.UI;
using UnityEngine;
using MaskedKiller.View;

namespace MaskedKiller.Factories.Selector
{
	public class WeaponSelectorFactory : SerializedMonoBehaviour, ISelectorFactory<IWeapon>
	{
		[SerializeField] private Dictionary<IWeaponFactory, Sprite> _weaponFactoriesAndImages;
		[SerializeField] private IWeaponSelectorView _view;

		public ISelector<IWeapon> Create()
		{
			var weaponWithImages = new List<WeaponWithSprite>();

			foreach (var keyValuePair in _weaponFactoriesAndImages)
			{
				weaponWithImages.Add(new WeaponWithSprite(keyValuePair.Key.Create(), keyValuePair.Value));
			}

			
			return new WeaponSelector(_view, weaponWithImages);
		}
	}
}
