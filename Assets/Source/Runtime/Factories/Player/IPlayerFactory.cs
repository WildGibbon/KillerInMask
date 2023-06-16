using MaskedKiller.Model.Player;
using MaskedKiller.Game.Data;

namespace MaskedKiller.Factories.Player
{
	public interface IPlayerFactory
	{
		IPlayer Create(IGameData gameData);
	}
}
