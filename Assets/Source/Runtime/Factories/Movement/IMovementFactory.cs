using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Movement;

namespace MaskedKiller.Factories.Movement
{
	public interface IMovementFactory
	{
		IMovement Create();
		void Init(IViews views);
	}
}
