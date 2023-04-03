using UnityEngine;

namespace MaskedKiller.Model.Character.Jump
{
	[RequireComponent(typeof(BoxCollider2D))]
	public class SurfaceCollisionDetector : MonoBehaviour, ISurfaceCollisionDetector
	{
		public bool IsActive { get; private set; }

		private void Awake()
		{
			GetComponent<BoxCollider2D>().isTrigger = true;
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			IsActive = true;
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
			IsActive = false;
		}
	}
}
