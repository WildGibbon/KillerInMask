using MaskedKiller.Model.Health;

namespace MaskedKiller.Model.Attack
{
	public interface IAttack
	{
		void Attack(IHealth health);
	}
}
