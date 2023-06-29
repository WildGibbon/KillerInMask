using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Pickups;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MaskedKiller.Factories.Pickups
{
	public class PickupableRigidbodies : MonoBehaviour, IRigidbodies
	{
		[SerializeField] private GameObject _prefab;
		[SerializeField] private int _count;

		private IManaStorage _manaStorage;

		public IReadOnlyList<Rigidbody2D> Get
		{
			get
			{
				var rigidbodies = new List<Rigidbody2D>();

				for (int i = 0; i < _count; i++)
				{
					var gameObject = Instantiate(_prefab);
					gameObject.GetComponent<IManaPickupableFactory>().Init(_manaStorage);

					rigidbodies.Add(gameObject.GetComponent<Rigidbody2D>());
				}

				return rigidbodies;
			}
		}

		public void Init(IManaStorage manaStorage)		
			=> _manaStorage = manaStorage ?? throw new ArgumentNullException(nameof(manaStorage));		
	}
}
