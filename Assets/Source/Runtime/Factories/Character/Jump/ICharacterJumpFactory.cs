using MaskedKiller.Model.Character.Jump;
using MaskedKiller.Game.Data.Views;

namespace MaskedKiller.Factories.Character.Jump
{
	public interface ICharacterJumpFactory
	{
		ICharacterJump Create();
		void Init(IViews views);
	}
}
