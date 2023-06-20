using UnityEngine;

namespace MaskedKiller.Model.Character.Jump
{
	public class SurfaceDetector : MonoBehaviour, ISurfaceDetector
	{
		[SerializeField] private float _activateDistance;

		public bool IsActive => Physics2D.Raycast(transform.position, Vector2.down, _activateDistance);
	}
}
