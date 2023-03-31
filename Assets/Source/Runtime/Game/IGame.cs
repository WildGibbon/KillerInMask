﻿using MaskedKiller.Factories.Player;
using MaskedKiller.Game.Data;

namespace MaskedKiller.Game
{
	public interface IGame
	{
		void Play();
		void Init(IGameData data, IPlayerFactory playerFactory);
	}
}