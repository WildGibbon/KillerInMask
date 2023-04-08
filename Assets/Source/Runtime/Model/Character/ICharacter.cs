using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedKiller.Model.Character
{
	public interface ICharacter
	{
		void Move(MoveDirection direction);
		void SwitchPreviousWeapon();
		void SwitchNextWeapon();
		void AttackWithWeapon();
		void Jump();
	}
}
