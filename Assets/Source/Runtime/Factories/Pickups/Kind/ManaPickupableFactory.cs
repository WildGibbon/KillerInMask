using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Pickups;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Pickups
{
	public class ManaPickupableFactory : SerializedMonoBehaviour, IManaPickupableFactory
	{
		[SerializeField] private IManaStorageFactory _manaStorageFactory;
		[SerializeField] private int _manaIncreaseValue;

		private IManaStorage _manaStorage;

		public IPickupable Create()
		{
			return new ManaPickupable(_manaStorageFactory.Create(), _manaIncreaseValue);
		}

		public void Init(IManaStorage manaStorage)
		{
			_manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));
		}

		//позже переделаю, щас как заглушка
	}
}