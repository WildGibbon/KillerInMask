using MaskedKiller.Game.Data.UI;
using MaskedKiller.Game.Data.Views;

namespace MaskedKiller.Game.Data
{
	public interface IGameData
	{
		IViews Views { get; }
		IUI UI { get; }
	}
}
