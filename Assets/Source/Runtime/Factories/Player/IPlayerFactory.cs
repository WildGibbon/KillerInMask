using MaskedKiller.Model.Player;
using MaskedKiller.Game.Data;
using MaskedKiller.Model.Character;

namespace MaskedKiller.Factories.Player
{
	public interface IPlayerFactory
	{
		IPlayer Create(ICharacter character);
	}
}
