using MaskedKiller.Model.Health;

namespace MaskedKiller.Model.Attack
{
	public interface IAttack
	{
		void ApplyTo(IHealth health);
	}
}
