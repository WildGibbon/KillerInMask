using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Ability.Mana;
using UnityEngine;

namespace MaskedKiller.Factories.Ability.Mana
{
	public class ManaStorageFactory : MonoBehaviour, IManaStorageFactory
	{
		[SerializeField] private int _maxValue;

		private IManaStorage _instance;

		public IManaStorage Create()
		{
			if(_instance != null)
				return _instance;

			_instance = new ManaStorage(_maxValue);

			return _instance;
		}
	}
}
