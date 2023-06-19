using UnityEngine;

namespace MaskedKiller.Model.Input
{
	public class PCMovementInput : MonoBehaviour, IMovementInput
	{
		public bool IsMovingRight => UnityEngine.Input.GetKey(KeyCode.D);

		public bool IsMovingLeft => UnityEngine.Input.GetKey(KeyCode.A);
	}
}
