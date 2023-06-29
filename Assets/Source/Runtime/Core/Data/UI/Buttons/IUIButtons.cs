using MaskedKiller.Model.UI;

namespace MaskedKiller.Game.Data.UI
{
	public interface IUIButtons
	{
		IUIButton PreviousWeaponButton { get; }
		IUIButton NextWeaponButton { get; }
		IUIButton WeaponAttackButton { get; }

		IUIButton AbilityUseButton { get; }
		IUIButton PreviousAbilityButton { get; }
		IUIButton NextAbilityButton { get; }
		
		IUIButton JumpButton { get; } 
	}
}
