using MaskedKiller.Model.Selector;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Factories.Selector
{
	public class SelectorFactory : SerializedMonoBehaviour, ISelectorFactory
	{
		[SerializeField] private List<dynamic> _items;

		public ISelector Create()
		{
			return new Model.Selector.Selector(_items);
		}
	}
}
