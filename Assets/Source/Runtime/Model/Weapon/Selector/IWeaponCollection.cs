using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedKiller.Model.Weapon
{
	public interface IWeaponCollection
	{
		IWeapon GetWeapon(int index);
		int Count { get; }
		void Add(IWeapon weapon);
		void Remove(int index);
	}
}
