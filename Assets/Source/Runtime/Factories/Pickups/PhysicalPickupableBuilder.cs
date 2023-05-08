using MaskedKiller.Model.Pickups;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Pickups
{
	public class PhysicalPickupableBuilder : SerializedMonoBehaviour
	{
		[SerializeField] private PhysicalPickupable _physicalPickupable;
		[SerializeField] private IPickupableFactory _pickupableFactory;

		private void Awake()
		{
			_physicalPickupable.Init(_pickupableFactory.Create());
		}
	}
}
