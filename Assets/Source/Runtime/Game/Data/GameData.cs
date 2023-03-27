using MaskedKiller.Game.Data.UI;
using MaskedKiller.Game.Data.Views;
using System;

namespace MaskedKiller.Game.Data
{
	public class GameData : IGameData
	{
		public IViews Views { get; private set; }
		public IUI UI { get; private set; }

		public GameData(IViews views, IUI uI)
		{
			Views = views ?? throw new ArgumentNullException(nameof(views));
			UI = uI ?? throw new ArgumentNullException(nameof(uI));
		}
	}
}
