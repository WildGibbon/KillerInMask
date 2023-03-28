using MaskedKiller.Game.Data.Views;
using MaskedKiller.Model.Character;
using Sirenix.OdinInspector;
using UnityEngine;
using System;

namespace MaskedKiller.Factories.Character
{
	public class CharacterFactory : SerializedMonoBehaviour, ICharacterFactory
	{
		private IViews _views;

		public ICharacter Create()
		{
			
		}

		public void Init(IViews views)
		{
			_views = views ?? throw new ArgumentNullException(nameof(views));
		}
	}
}
