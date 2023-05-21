using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Ability;
using MaskedKiller.View.Mana;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Ability.Mana
{
	public class ManaStorageFactory : SerializedMonoBehaviour, IManaStorageFactory
	{
		[SerializeField] private IManaStorageView _view;
		[SerializeField] private int _maxValue;

		private IManaStorage _instance;

		public IManaStorage Create()
		{
			if(_instance != null)
				return _instance;

			_instance = new ManaStorage(_view, _maxValue);

			return _instance;
		}
	}
}
