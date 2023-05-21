using UnityEngine;
using System;

namespace MaskedKiller.Model.Pickups
{
	public class PhysicalPickupable : MonoBehaviour, IPickupable
	{
		private IPickupable _pickupable;

		public void Init(IPickupable pickupable)
		{
			_pickupable = pickupable ?? throw new ArgumentNullException(nameof(pickupable));
		}

		public void Pickup()
		{
			_pickupable.Pickup();
			Destroy(gameObject);
		}
	}
}
