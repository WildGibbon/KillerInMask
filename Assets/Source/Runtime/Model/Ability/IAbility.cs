namespace MaskedKiller.Model.Ability
{
	public interface IAbility
	{
		bool CanUse { get; }
		void Use();
	}
}
