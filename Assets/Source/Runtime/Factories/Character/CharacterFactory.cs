using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character;
using System;

namespace MaskedKiller.Factories.Character
{
	public class CharacterFactory : ICharacterFactory
	{
		private IViews _views;

		public ICharacter Create()
		{
			throw new System.NotImplementedException();
		}

		public void Init(IViews views)
		{
			_views = views ?? throw new ArgumentNullException(nameof(views));
		}
	}
}
