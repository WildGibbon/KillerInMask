using MaskedKiller.Model.Character.Movement;

namespace MaskedKiller.Factories.Character.Movement
{
	public interface IMovementFactory
	{
		ICharacterMovement Create();
	}
}
