using MaskedKiller.View.CharacterJump;
using MaskedKiller.View.Health;
using MaskedKiller.View.Movement;

namespace MaskedKiller.Game.Data.Views
{
	public interface IViews
	{
		IMovementView MovementView { get; }
		ICharacterJumpView CharacterJumpView { get; }
		IHealthView HealthView { get; }
	}
}
