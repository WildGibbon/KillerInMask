using UnityEngine;

namespace MaskedKiller.Model.Pickups
{
	public class Picker : MonoBehaviour
	{
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if(collision.TryGetComponent<IPickupable>(out var pickupable))
				pickupable.Pickup();
		}
	}
}
