namespace MaskedKiller.Model.Health
{
	public interface IHealth
	{
		bool IsDead { get; }
		void TakeDamage(int value);
		void Heal(int value);
	}
}
