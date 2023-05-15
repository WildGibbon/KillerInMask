using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Model.Character
{
	public interface ICharacter
	{
		void Move(MoveDirection direction);
		void AttackWithWeapon(IWeapon weapon);
		void Jump();
	}
}
