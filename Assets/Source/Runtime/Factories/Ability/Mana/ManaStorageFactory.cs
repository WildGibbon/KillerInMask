using MaskedKiller.Model.Ability.Mana;
using MaskedKiller.Model.Ability;
using UnityEngine;
using MaskedKiller.Game.Data.Views;

namespace MaskedKiller.Factories.Ability.Mana
{
	public class ManaStorageFactory : MonoBehaviour, IManaStorageFactory
	{
		[SerializeField] private int _maxValue;

		private IManaStorage _instance;

		public IManaStorage Create(IViews views)
		{
			if(_instance != null)
				return _instance;

			_instance = new ManaStorage(views.ManaStorageView, _maxValue);

			return _instance;
		}
	}
}
