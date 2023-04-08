using MaskedKiller.Model.Character.Movement;
using MaskedKiller.Game.Data.Views;

namespace MaskedKiller.Factories.Character.Movement
{
	public interface IMovementFactory
	{
		ICharacterMovement Create(IViews views);
	}
}
