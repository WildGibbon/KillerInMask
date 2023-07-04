using MaskedKiller.Model.Health;
using MaskedKiller.View.Health;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Health
{
	public class HealthFactory : SerializedMonoBehaviour, IHealthFactory
	{
		[SerializeField] private IHealthView _view;
		[SerializeField] private int _healthValue;

		private IHealth _createdHealth;

		public IHealth Create()
		{
			if(_createdHealth != null)
				return _createdHealth;

			_createdHealth = new Model.Health.Health(_view, _healthValue);

			return _createdHealth;
		}
	}
}
