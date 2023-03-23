using KillerInMask.Model.UI;
using UnityEngine;

namespace KillerInMask.Model.Input
{
	public class MovementInput : MonoBehaviour, IMovementInput
	{
		[SerializeField] private HoldElement _moveRightButton;
		[SerializeField] private HoldElement _moveLeftButton;

		public bool IsMovingRight => _moveRightButton.IsHold;

		public bool IsMovingLeft => _moveLeftButton.IsHold;
	}
}
