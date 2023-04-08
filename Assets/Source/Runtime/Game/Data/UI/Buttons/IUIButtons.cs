using MaskedKiller.Model.UI;

namespace MaskedKiller.Game.Data.UI
{
	public interface IUIButtons
	{
		IUIButton PreviousWeaponButton { get; }
		IUIButton NextWeaponButton { get; }

		IUIButton WeaponAttackButton { get; }
		IUIButton JumpButton { get; } 
	}
}
