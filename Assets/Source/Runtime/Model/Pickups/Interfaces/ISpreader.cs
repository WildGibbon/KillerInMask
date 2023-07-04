using MaskedKiller.Factories.Pickups;
using System.Collections.Generic;
using UnityEngine;

namespace MaskedKiller.Model.Pickups
{
	public interface ISpreader
	{
		void Use();
		void Init(IThrowablesFactory factory);
	}
}
