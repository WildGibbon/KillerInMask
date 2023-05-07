using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Pickups;
using System;
using UnityEngine;

namespace MaskedKiller.Factories.Pickups
{
	public class ManaPickupableFactory : MonoBehaviour, IPickupableFactory, IManaPickupableFactoryInit
	{
		[SerializeField] private int _manaIncreaseValue;

		private IManaStorage _manaStorage;

		public IPickupable Create()
		{
			return new ManaPickupable(_manaStorage, _manaIncreaseValue);
		}

		public void Init(IManaStorage manaStorage)
		{
			_manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));
		}
	}
}
