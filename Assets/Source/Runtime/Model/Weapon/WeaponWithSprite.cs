using System;
using UnityEngine;
using UnityEngine.UI;

namespace MaskedKiller.Model.Weapon
{
	public struct WeaponWithSprite
	{
		public readonly IWeapon Weapon;
		public readonly Sprite Sprite;

		public WeaponWithSprite(IWeapon weapon, Sprite sprite)
		{
			Sprite = sprite ?? throw new ArgumentNullException(nameof(sprite));
			Weapon = weapon ?? throw new ArgumentNullException(nameof(weapon));
		}
	}
}
