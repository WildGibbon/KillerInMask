using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Pickups;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Pickups
{
	public class ManaPickupableFactory : SerializedMonoBehaviour, IPickupableFactory
	{
		[SerializeField] private IManaStorageFactory _manaStorageFactory;
		[SerializeField] private int _manaIncreaseValue;

		private IManaStorage _manaStorage;

		public IPickupable Create()
		{
			return new ManaPickupable(_manaStorageFactory.Create(), _manaIncreaseValue);
		}
	}
}