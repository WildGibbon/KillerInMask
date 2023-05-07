namespace MaskedKiller.Model.Ability.Mana
{
	public interface IManaStorage
	{
		int CurrentValue { get; }

		void TakeMana(int amount);
		void AddMana(int amount);

		bool CanTakeMana(int amount);
		bool CanAddMana(int amount);
	}
}
