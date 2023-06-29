using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Game.Data.UI
{
	public class UI : SerializedMonoBehaviour, IUI
	{
		[field: SerializeField] public IUIButtons Buttons { get; private set; }
	}
}
