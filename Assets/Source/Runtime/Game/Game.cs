using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Factories.Player;
using MaskedKiller.Game.Data.Views;
using MaskedKiller.Game.Data.UI;
using MaskedKiller.Game.Data;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Game
{
	public class Game : SerializedMonoBehaviour, IGame
	{
		[SerializeField] private IPlayerFactory _playerFactory;
		[SerializeField] private IViews _views;
		[SerializeField] private IUI _ui;

		private ISystemUpdate _systemUpdates;

		public void Play()
		{
			var gameData = new GameData(_views, _ui);
			_systemUpdates = new SystemUpdate();

			_systemUpdates.Add(_playerFactory.Create(gameData));
		}

		private void Update()
		{
			_systemUpdates.UpdateAll(Time.deltaTime);
		}
	}
}
