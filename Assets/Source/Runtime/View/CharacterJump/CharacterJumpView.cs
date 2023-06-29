using UnityEngine;

namespace MaskedKiller.View.CharacterJump
{
	public class CharacterJumpView : MonoBehaviour, ICharacterJumpView
	{
		//убрать это говно
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Visualize(float jumpForce)
		{
			_rigidbody.AddForce(jumpForce * Vector2.up);
		}
	}
}
