using MaskedKiller.Pickups.Interfaces;
using MaskedKiller.Model.Pickups;
using System.Collections.Generic;
using UnityEngine;

namespace MaskedKiller.Factories.Pickups
{
	public class ThrowablesFactory : MonoBehaviour, IThrowablesFactory
	{
		[SerializeField] private GameObject _prefab;
		[SerializeField] private int _count;

		public IReadOnlyList<IThrowable> Create()
		{
			var throwables = new List<IThrowable>();

			for (int i = 0; i < _count; i++)
			{
				var gameObject = Instantiate(_prefab, transform.position, Quaternion.identity, transform);
				throwables.Add(gameObject.GetComponent<IThrowable>());
			}

			return throwables;
		}
	}
}
