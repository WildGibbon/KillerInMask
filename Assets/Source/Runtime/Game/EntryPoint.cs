using MaskedKiller.Game.Data.UI;
using MaskedKiller.Game.Data.Views;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
using MaskedKiller.Game.Data;
using MaskedKiller.Factories.Player;

namespace MaskedKiller.Game
{ 
	public class EntryPoint : SerializedMonoBehaviour
	{
		[SerializeField] private IGame _game;

		private void Awake()
		{
			_game.Play();
		}
	}
}
