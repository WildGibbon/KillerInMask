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
		[SerializeField] private IPlayerFactory _playerFactory;
		[SerializeField] private IViews _views;
		[SerializeField] private IGame _game;
		[SerializeField] private IUI _ui;

		private void Awake()
		{
			var gameData = new GameData(_views, _ui);

			_game.Init(gameData, _playerFactory);
			_game.Play();
		}
	}
}
