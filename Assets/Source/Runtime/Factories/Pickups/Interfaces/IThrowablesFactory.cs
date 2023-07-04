using MaskedKiller.Pickups.Interfaces;
using System.Collections.Generic;

namespace MaskedKiller.Factories.Pickups
{
	public interface IThrowablesFactory
	{
		IReadOnlyList<IThrowable> Create();
	}
}
