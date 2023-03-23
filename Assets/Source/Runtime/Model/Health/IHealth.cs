namespace MaskedKiller.Model.Health
{
	public interface IHealth
	{
		int Value { get; }
		int MaxValue { get; }
		bool IsDead { get; }

		void TakeDamage(int value);
		void Heal(int value);
		bool CanHeal(int value);
	}
}
