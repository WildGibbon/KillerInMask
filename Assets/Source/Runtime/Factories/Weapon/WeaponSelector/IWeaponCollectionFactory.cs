using MaskedKiller.Model.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedKiller.Factories.Weapon
{
	public interface IWeaponCollectionFactory
	{
		IWeaponCollection Create();
	}
}
