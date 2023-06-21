using UnityEngine;

namespace MaskedKiller.Model.Character
{
	public interface ICharacter
	{
		Vector2 ViewDirection { get; }
		void Move(CharacterMoveDirection direction);
		void Jump();
	}
}
