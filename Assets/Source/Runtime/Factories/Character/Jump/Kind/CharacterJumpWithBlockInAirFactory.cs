using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character.Jump;
using UnityEngine;

namespace MaskedKiller.Factories.Character.Jump
{
	public class CharacterJumpWithBlockInAirFactory : ICharacterJumpFactory
	{
		[SerializeField] private ISurfaceCollisionDetector _collisionDetector;
		[SerializeField] private ICharacterJumpFactory _jumpFactory;

		public ICharacterJump Create(IViews views)
		{
			return new CharacterJumpWithBlockInAir(_collisionDetector, _jumpFactory.Create(views));
		}
	}
}
