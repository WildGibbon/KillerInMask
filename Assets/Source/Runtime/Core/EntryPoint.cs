using Sirenix.OdinInspector;
using UnityEngine;

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
