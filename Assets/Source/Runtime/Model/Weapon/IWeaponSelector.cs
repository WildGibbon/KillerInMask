using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedKiller.Model.Weapon
{
	public interface IWeaponSelector
	{
		IWeapon CurrrentWeapon { get; }
		void PreviousWeapons();
		void NextWeapon();
	}
}
