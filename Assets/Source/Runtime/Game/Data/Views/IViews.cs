using MaskedKiller.View.CharacterJump;
using MaskedKiller.View.Movement;
using MaskedKiller.View.Health;
using MaskedKiller.View.Mana;

namespace MaskedKiller.Game.Data.Views
{
	public interface IViews
	{
		ICharacterJumpView CharacterJumpView { get; }
		IManaStorageView ManaStorageView { get; }
		IMovementView MovementView { get; }
		IHealthView HealthView { get; }
	}
}
