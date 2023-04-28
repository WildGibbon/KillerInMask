using MaskedKiller.Model.Selector;
using MaskedKiller.Model.Weapon;

namespace MaskedKiller.Factories.Selector
{
	public interface ISelectorFactory<T>
	{
		ISelector<T> Create();
	}
}
