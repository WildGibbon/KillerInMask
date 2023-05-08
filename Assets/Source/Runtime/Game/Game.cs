using MaskedKiller.Factories.Ability.Mana;
using MaskedKiller.Game.SystemUpdates;
using MaskedKiller.Factories.Player;
using MaskedKiller.Game.Data;
using UnityEngine;
using System;

namespace MaskedKiller.Game
{
	public class Game : MonoBehaviour, IGame
	{
		private IManaStorageFactory _manaStorageFactory;
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
