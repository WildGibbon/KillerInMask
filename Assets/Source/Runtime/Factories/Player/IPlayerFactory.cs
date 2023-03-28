using MaskedKiller.Game.Data.UI;
using MaskedKiller.Model.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskedKiller.Factories.Player
{
	public interface IPlayerFactory
	{
		IPlayer Create();
		void Init(IUI ui);
	}
}
