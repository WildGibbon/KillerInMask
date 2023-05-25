using UnityEngine.UI;
using UnityEngine;
using System;

namespace MaskedKiller.View.Selector
{
	public class WeaponSelectorView : MonoBehaviour, IWeaponSelectorView
	{
		[SerializeField] private Image _image;

		public void Visualize(Sprite sprite)
		{
			_image.sprite = sprite;
		}
	}
}
