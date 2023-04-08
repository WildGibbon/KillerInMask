using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character;

namespace MaskedKiller.Factories.Character
{
	public interface ICharacterFactory
	{
		ICharacter Create(IViews views);
	}
}
