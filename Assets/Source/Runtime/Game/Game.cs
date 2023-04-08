using MaskedKiller.Factories.Player;
using MaskedKiller.Game.Data;
using MaskedKiller.Game.SystemUpdates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Game
{
	public class Game : MonoBehaviour, IGame
	{
		private IPlayerFactory _playerFactory;
		private ISystemUpdate _systemUpdates;
		private IGameData _gameData;

		public void Play()
		{
			_systemUpdates.Add(_playerFactory.Create(_gameData));
		}

		private void Update()
		{
			_systemUpdates.UpdateAll(Time.deltaTime);
		}

		public void Init(IGameData data, IPlayerFactory playerFactory)
		{
			_playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
			_gameData = data ?? throw new ArgumentNullException(nameof(data));
			_systemUpdates = new SystemUpdate();
		}
	}
}
