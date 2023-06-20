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

		public IHealth Create()
		{
			return new Model.Health.Health(_view, _healthValue);
		}
	}
}
